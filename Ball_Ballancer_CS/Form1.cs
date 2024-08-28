using Ball_Ballancer_CS.Class;
using System;
using System.Collections;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ball_Ballancer_CS
{
    public partial class Form1 : Form
    {
        float[] passed_data = new float[4];
        UTF8 UTF8 = new UTF8();
        DataPassing data = new DataPassing();

        private ArrayList al;
        private Point p;

        float[] pb_point = new float[2];
        float[] pb_point_pre = new float[2];

        public Form1()
        {
            InitializeComponent();
            al = new ArrayList();
            this.Text = "Ball_Balancer 제어프로그램";
        }

        private void Form1_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            try
            {
                comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
            }
            catch { }
        }

        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            try
            {
                if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
                {
                    serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                    serialPort1.BaudRate = 115200;  //보레이트 변경이 필요하면 숫자 변경하기
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                    serialPort1.Open();  //시리얼포트 열기

                    label_status.Text = "포트가 열렸습니다.";
                    comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
                                                    //timer1.Start();
                }
                else  //시리얼포트가 열려 있으면
                {
                    label_status.Text = "포트가 이미 열려 있습니다.";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            try
            {
                this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
            }
            catch { }
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            //int ReceiveData = serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //richTextBox_received.Text = richTextBox_received.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
            try
            {
                int iRecSize = serialPort1.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize != 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        serialPort1.Read(buff, 0, iRecSize);
                        passed_data = data.dataPassing(buff, iRecSize);
                        if (passed_data != null)
                        {
                            if (passed_data[0] == 0)
                            {
                                tb_X_Point.Text = passed_data[1].ToString();
                                tb_Y_Point.Text = passed_data[2].ToString();

                                pb_point[0] = map(passed_data[1], 60, 950, 0, 448);
                                pb_point[1] = map(passed_data[2], 85, 920, 258, 0);

                                Graphics g = pb_Ball_Display.CreateGraphics();
                                g.DrawLine(Pens.Black, pb_point_pre[0], pb_point_pre[1], pb_point[0], pb_point[1]);
                                pb_point_pre[0] = pb_point[0];
                                pb_point_pre[1] = pb_point[1];
                                g.Dispose();
                            }
                            else if(passed_data[0] == 1)
                            {
                                tb_P.Text = passed_data[1].ToString();
                                tb_I.Text = passed_data[2].ToString();
                                tb_D.Text = passed_data[3].ToString();
                            }

                        }

                        if (this.CB_Enable_Terminal.Checked && this.radioButton_ASCII.Checked)
                        {
                            string strTemp = this.UTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);
                            TextBox_received.AppendText(strTemp);
                            TextBox_received.AppendText("\r\n");

                        }

                        if (this.CB_Enable_Terminal.Checked && this.radioButton_HEX.Checked)
                        {
                            TextBox_received.AppendText(BitConverter.ToString(buff).Replace("-", " ") + " ");
                            TextBox_received.AppendText("\r\n");
                        }
                    }
                    catch { }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            try
            {
                serialPort1.Write(textBox_send.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            catch{}
        }

        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void bt_pid_recive_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[20];
            try
            {
                buff[0] = 0x47;
                buff[1] = 0x53;
                buff[2] = 0x10;
                buff[3] = 0;
                buff[4] = 0;
                buff[5] = 0;
                buff[6] = 0;
                buff[7] = 0;
                buff[8] = 0;
                buff[9] = 0;
                buff[10] = 0;
                buff[11] = 0;
                buff[12] = 0;
                buff[13] = 0;
                buff[14] = 0;
                buff[15] = 0;
                buff[16] = 0;
                buff[17] = 0;
                buff[18] = 0;
                buff[19] = 0xff;
            }
            catch { }

            for (int i = 0; i < 19; i++)
            {
                buff[19] -= buff[i];
            }
            TextBox_received.AppendText(Encoding.UTF8.GetString(buff));
            try
            {
                serialPort1.Write(Encoding.UTF8.GetString(buff));
            }
            catch { }
        }

        private void bt_pid_send_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[20];
            float float_buff;
            byte[] tmp = new byte[4];
            try
            {
                buff[0] = 0x47;
                buff[1] = 0x53;
                buff[2] = 0x00;
                float_buff = float.Parse(tb_P.Text);
                tmp = BitConverter.GetBytes(float_buff);
                buff[3] = tmp[0];
                buff[4] = tmp[1];
                buff[5] = tmp[2];
                buff[6] = tmp[3];
                float_buff = float.Parse(tb_I.Text);
                tmp = BitConverter.GetBytes(float_buff);
                buff[7] = tmp[0];
                buff[8] = tmp[1];
                buff[9] = tmp[2];
                buff[10] = tmp[3];
                float_buff = float.Parse(tb_D.Text);
                tmp = BitConverter.GetBytes(float_buff);
                buff[11] = tmp[0];
                buff[12] = tmp[1];
                buff[13] = tmp[2];
                buff[14] = tmp[3];
                buff[15] = 0;
                buff[16] = 0;
                buff[17] = 0;
                buff[18] = 0;
                buff[19] = 0xff;
            } catch { }

            for(int i=0; i < 19;i++)
            {
                buff[19] -= buff[i];
            }
            TextBox_received.AppendText(Encoding.UTF8.GetString(buff));
            TextBox_received.AppendText("\r\n");
            try
            {
                serialPort1.Write(buff,0,20);
            } catch { }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            TextBox_received.Clear();
        }

        private void pb_Ball_Display_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
        }

        private void pb_Ball_Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = pb_Ball_Display.CreateGraphics();
                g.DrawLine(Pens.Black, p.X, p.Y, e.X, e.Y);

                //이미지 파일로 저장하기 위한 좌표 정보 저장.
                al.Add(Rectangle.FromLTRB(p.X, p.Y, e.X, e.Y));

                p.X = e.X; p.Y = e.Y;
                g.Dispose();
            }
        }

        private void bt_Dsp_Clear_Click(object sender, EventArgs e)
        {
            pb_Ball_Display.Image = null;
        }

        public float map(float x, float in_min, float in_max, float out_min, float out_max)
        {
            return ((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min);
        }
    }
}
