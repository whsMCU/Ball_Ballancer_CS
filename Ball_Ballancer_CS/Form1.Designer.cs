namespace Ball_Ballancer_CS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.groupBox_RxFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_HEX = new System.Windows.Forms.RadioButton();
            this.radioButton_ASCII = new System.Windows.Forms.RadioButton();
            this.CB_Enable_Terminal = new System.Windows.Forms.CheckBox();
            this.TextBox_received = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label_send = new System.Windows.Forms.Label();
            this.pb_Ball_Display = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Dsp_Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Y_Point = new System.Windows.Forms.TextBox();
            this.tb_X_Point = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_pid_recive = new System.Windows.Forms.Button();
            this.bt_pid_send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_D = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_I = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_P = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_demo = new System.Windows.Forms.Button();
            this.bt_figure8 = new System.Windows.Forms.Button();
            this.bt_sinusoidal = new System.Windows.Forms.Button();
            this.bt_ellipse = new System.Windows.Forms.Button();
            this.bt_pinball = new System.Windows.Forms.Button();
            this.bt_square = new System.Windows.Forms.Button();
            this.bt_triangle = new System.Windows.Forms.Button();
            this.bt_line = new System.Windows.Forms.Button();
            this.bt_center = new System.Windows.Forms.Button();
            this.groupBox_RxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball_Display)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 78);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 12);
            this.label_status.TabIndex = 35;
            this.label_status.Text = "연결상태";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(95, 93);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_disconnect.TabIndex = 34;
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 46);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_port.TabIndex = 31;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 93);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 33;
            this.button_connect.Text = "연결하기";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(12, 28);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 12);
            this.label_port.TabIndex = 32;
            this.label_port.Text = "COM 포트 설정";
            // 
            // groupBox_RxFormat
            // 
            this.groupBox_RxFormat.Controls.Add(this.radioButton_HEX);
            this.groupBox_RxFormat.Controls.Add(this.radioButton_ASCII);
            this.groupBox_RxFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_RxFormat.Location = new System.Drawing.Point(3, 328);
            this.groupBox_RxFormat.Name = "groupBox_RxFormat";
            this.groupBox_RxFormat.Size = new System.Drawing.Size(83, 70);
            this.groupBox_RxFormat.TabIndex = 41;
            this.groupBox_RxFormat.TabStop = false;
            this.groupBox_RxFormat.Text = "Rx_Format";
            // 
            // radioButton_HEX
            // 
            this.radioButton_HEX.AutoSize = true;
            this.radioButton_HEX.Location = new System.Drawing.Point(7, 45);
            this.radioButton_HEX.Name = "radioButton_HEX";
            this.radioButton_HEX.Size = new System.Drawing.Size(47, 16);
            this.radioButton_HEX.TabIndex = 1;
            this.radioButton_HEX.Text = "HEX";
            this.radioButton_HEX.UseVisualStyleBackColor = true;
            // 
            // radioButton_ASCII
            // 
            this.radioButton_ASCII.AutoSize = true;
            this.radioButton_ASCII.Checked = true;
            this.radioButton_ASCII.Location = new System.Drawing.Point(7, 18);
            this.radioButton_ASCII.Name = "radioButton_ASCII";
            this.radioButton_ASCII.Size = new System.Drawing.Size(54, 16);
            this.radioButton_ASCII.TabIndex = 0;
            this.radioButton_ASCII.TabStop = true;
            this.radioButton_ASCII.Text = "ASCII";
            this.radioButton_ASCII.UseVisualStyleBackColor = true;
            // 
            // CB_Enable_Terminal
            // 
            this.CB_Enable_Terminal.AutoSize = true;
            this.CB_Enable_Terminal.Location = new System.Drawing.Point(92, 181);
            this.CB_Enable_Terminal.Name = "CB_Enable_Terminal";
            this.CB_Enable_Terminal.Size = new System.Drawing.Size(117, 16);
            this.CB_Enable_Terminal.TabIndex = 40;
            this.CB_Enable_Terminal.Text = "Enable Terminal";
            this.CB_Enable_Terminal.UseVisualStyleBackColor = true;
            // 
            // TextBox_received
            // 
            this.TextBox_received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_received.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_received.Location = new System.Drawing.Point(92, 203);
            this.TextBox_received.Multiline = true;
            this.TextBox_received.Name = "TextBox_received";
            this.TextBox_received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received.Size = new System.Drawing.Size(297, 195);
            this.TextBox_received.TabIndex = 39;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(90, 404);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(204, 21);
            this.textBox_send.TabIndex = 36;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(300, 403);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 37;
            this.button_send.Text = "보내기";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Location = new System.Drawing.Point(57, 407);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 12);
            this.label_send.TabIndex = 38;
            this.label_send.Text = "송신";
            // 
            // pb_Ball_Display
            // 
            this.pb_Ball_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Ball_Display.Location = new System.Drawing.Point(6, 46);
            this.pb_Ball_Display.Name = "pb_Ball_Display";
            this.pb_Ball_Display.Size = new System.Drawing.Size(448, 258);
            this.pb_Ball_Display.TabIndex = 42;
            this.pb_Ball_Display.TabStop = false;
            this.pb_Ball_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Ball_Display_MouseDown);
            this.pb_Ball_Display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Ball_Display_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Clear);
            this.groupBox1.Controls.Add(this.label_port);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.TextBox_received);
            this.groupBox1.Controls.Add(this.comboBox_port);
            this.groupBox1.Controls.Add(this.label_send);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.groupBox_RxFormat);
            this.groupBox1.Controls.Add(this.button_disconnect);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.CB_Enable_Terminal);
            this.groupBox1.Controls.Add(this.textBox_send);
            this.groupBox1.Location = new System.Drawing.Point(479, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 437);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial_Communication";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(280, 174);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(95, 23);
            this.bt_Clear.TabIndex = 42;
            this.bt_Clear.Text = "터미널 지우기";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Dsp_Clear);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Y_Point);
            this.groupBox2.Controls.Add(this.tb_X_Point);
            this.groupBox2.Controls.Add(this.pb_Ball_Display);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 316);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ball_Display";
            // 
            // bt_Dsp_Clear
            // 
            this.bt_Dsp_Clear.Location = new System.Drawing.Point(325, 17);
            this.bt_Dsp_Clear.Name = "bt_Dsp_Clear";
            this.bt_Dsp_Clear.Size = new System.Drawing.Size(116, 23);
            this.bt_Dsp_Clear.TabIndex = 43;
            this.bt_Dsp_Clear.Text = "터치패널 지우기";
            this.bt_Dsp_Clear.UseVisualStyleBackColor = true;
            this.bt_Dsp_Clear.Click += new System.EventHandler(this.bt_Dsp_Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "X";
            // 
            // tb_Y_Point
            // 
            this.tb_Y_Point.Location = new System.Drawing.Point(189, 19);
            this.tb_Y_Point.Name = "tb_Y_Point";
            this.tb_Y_Point.Size = new System.Drawing.Size(100, 21);
            this.tb_Y_Point.TabIndex = 44;
            // 
            // tb_X_Point
            // 
            this.tb_X_Point.Location = new System.Drawing.Point(47, 19);
            this.tb_X_Point.Name = "tb_X_Point";
            this.tb_X_Point.Size = new System.Drawing.Size(100, 21);
            this.tb_X_Point.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_pid_recive);
            this.groupBox3.Controls.Add(this.bt_pid_send);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_D);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_I);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_P);
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 115);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID상수";
            // 
            // bt_pid_recive
            // 
            this.bt_pid_recive.Location = new System.Drawing.Point(236, 69);
            this.bt_pid_recive.Name = "bt_pid_recive";
            this.bt_pid_recive.Size = new System.Drawing.Size(115, 23);
            this.bt_pid_recive.TabIndex = 53;
            this.bt_pid_recive.Text = "데이터 가져오기";
            this.bt_pid_recive.UseVisualStyleBackColor = true;
            this.bt_pid_recive.Click += new System.EventHandler(this.bt_pid_recive_Click);
            // 
            // bt_pid_send
            // 
            this.bt_pid_send.Location = new System.Drawing.Point(53, 69);
            this.bt_pid_send.Name = "bt_pid_send";
            this.bt_pid_send.Size = new System.Drawing.Size(111, 23);
            this.bt_pid_send.TabIndex = 52;
            this.bt_pid_send.Text = "데이터 보내기";
            this.bt_pid_send.UseVisualStyleBackColor = true;
            this.bt_pid_send.Click += new System.EventHandler(this.bt_pid_send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 51;
            this.label5.Text = "D";
            // 
            // tb_D
            // 
            this.tb_D.Location = new System.Drawing.Point(317, 27);
            this.tb_D.Name = "tb_D";
            this.tb_D.Size = new System.Drawing.Size(100, 21);
            this.tb_D.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(8, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "I";
            // 
            // tb_I
            // 
            this.tb_I.Location = new System.Drawing.Point(173, 27);
            this.tb_I.Name = "tb_I";
            this.tb_I.Size = new System.Drawing.Size(100, 21);
            this.tb_I.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "P";
            // 
            // tb_P
            // 
            this.tb_P.Location = new System.Drawing.Point(33, 27);
            this.tb_P.Name = "tb_P";
            this.tb_P.Size = new System.Drawing.Size(100, 21);
            this.tb_P.TabIndex = 46;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_demo);
            this.groupBox4.Controls.Add(this.bt_figure8);
            this.groupBox4.Controls.Add(this.bt_sinusoidal);
            this.groupBox4.Controls.Add(this.bt_ellipse);
            this.groupBox4.Controls.Add(this.bt_pinball);
            this.groupBox4.Controls.Add(this.bt_square);
            this.groupBox4.Controls.Add(this.bt_triangle);
            this.groupBox4.Controls.Add(this.bt_line);
            this.groupBox4.Controls.Add(this.bt_center);
            this.groupBox4.Location = new System.Drawing.Point(12, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 93);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "패턴 선택";
            // 
            // bt_demo
            // 
            this.bt_demo.Location = new System.Drawing.Point(760, 20);
            this.bt_demo.Name = "bt_demo";
            this.bt_demo.Size = new System.Drawing.Size(75, 63);
            this.bt_demo.TabIndex = 8;
            this.bt_demo.Text = "데모";
            this.bt_demo.UseVisualStyleBackColor = true;
            this.bt_demo.Click += new System.EventHandler(this.bt_demo_Click);
            // 
            // bt_figure8
            // 
            this.bt_figure8.Location = new System.Drawing.Point(667, 20);
            this.bt_figure8.Name = "bt_figure8";
            this.bt_figure8.Size = new System.Drawing.Size(75, 63);
            this.bt_figure8.TabIndex = 7;
            this.bt_figure8.Text = "그림8";
            this.bt_figure8.UseVisualStyleBackColor = true;
            this.bt_figure8.Click += new System.EventHandler(this.bt_figure8_Click);
            // 
            // bt_sinusoidal
            // 
            this.bt_sinusoidal.Location = new System.Drawing.Point(574, 20);
            this.bt_sinusoidal.Name = "bt_sinusoidal";
            this.bt_sinusoidal.Size = new System.Drawing.Size(75, 63);
            this.bt_sinusoidal.TabIndex = 6;
            this.bt_sinusoidal.Text = "정현파";
            this.bt_sinusoidal.UseVisualStyleBackColor = true;
            this.bt_sinusoidal.Click += new System.EventHandler(this.bt_sinusoidal_Click);
            // 
            // bt_ellipse
            // 
            this.bt_ellipse.Location = new System.Drawing.Point(481, 20);
            this.bt_ellipse.Name = "bt_ellipse";
            this.bt_ellipse.Size = new System.Drawing.Size(75, 63);
            this.bt_ellipse.TabIndex = 5;
            this.bt_ellipse.Text = "타원";
            this.bt_ellipse.UseVisualStyleBackColor = true;
            this.bt_ellipse.Click += new System.EventHandler(this.bt_ellipse_Click);
            // 
            // bt_pinball
            // 
            this.bt_pinball.Location = new System.Drawing.Point(388, 20);
            this.bt_pinball.Name = "bt_pinball";
            this.bt_pinball.Size = new System.Drawing.Size(75, 63);
            this.bt_pinball.TabIndex = 4;
            this.bt_pinball.Text = "볼링";
            this.bt_pinball.UseVisualStyleBackColor = true;
            this.bt_pinball.Click += new System.EventHandler(this.bt_pinball_Click);
            // 
            // bt_square
            // 
            this.bt_square.Location = new System.Drawing.Point(295, 20);
            this.bt_square.Name = "bt_square";
            this.bt_square.Size = new System.Drawing.Size(75, 63);
            this.bt_square.TabIndex = 3;
            this.bt_square.Text = "사각형";
            this.bt_square.UseVisualStyleBackColor = true;
            this.bt_square.Click += new System.EventHandler(this.bt_square_Click);
            // 
            // bt_triangle
            // 
            this.bt_triangle.Location = new System.Drawing.Point(202, 20);
            this.bt_triangle.Name = "bt_triangle";
            this.bt_triangle.Size = new System.Drawing.Size(75, 63);
            this.bt_triangle.TabIndex = 2;
            this.bt_triangle.Text = "삼각형";
            this.bt_triangle.UseVisualStyleBackColor = true;
            this.bt_triangle.Click += new System.EventHandler(this.bt_triangle_Click);
            // 
            // bt_line
            // 
            this.bt_line.Location = new System.Drawing.Point(109, 20);
            this.bt_line.Name = "bt_line";
            this.bt_line.Size = new System.Drawing.Size(75, 63);
            this.bt_line.TabIndex = 1;
            this.bt_line.Text = "라인";
            this.bt_line.UseVisualStyleBackColor = true;
            this.bt_line.Click += new System.EventHandler(this.bt_line_Click);
            // 
            // bt_center
            // 
            this.bt_center.Location = new System.Drawing.Point(16, 20);
            this.bt_center.Name = "bt_center";
            this.bt_center.Size = new System.Drawing.Size(75, 63);
            this.bt_center.TabIndex = 0;
            this.bt_center.Text = "원점";
            this.bt_center.UseVisualStyleBackColor = true;
            this.bt_center.Click += new System.EventHandler(this.bt_center_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_RxFormat.ResumeLayout(false);
            this.groupBox_RxFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball_Display)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.GroupBox groupBox_RxFormat;
        private System.Windows.Forms.RadioButton radioButton_HEX;
        private System.Windows.Forms.RadioButton radioButton_ASCII;
        private System.Windows.Forms.CheckBox CB_Enable_Terminal;
        private System.Windows.Forms.TextBox TextBox_received;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.PictureBox pb_Ball_Display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_X_Point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Y_Point;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_pinball;
        private System.Windows.Forms.Button bt_square;
        private System.Windows.Forms.Button bt_triangle;
        private System.Windows.Forms.Button bt_line;
        private System.Windows.Forms.Button bt_center;
        private System.Windows.Forms.Button bt_demo;
        private System.Windows.Forms.Button bt_figure8;
        private System.Windows.Forms.Button bt_sinusoidal;
        private System.Windows.Forms.Button bt_ellipse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_D;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_I;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_P;
        private System.Windows.Forms.Button bt_pid_recive;
        private System.Windows.Forms.Button bt_pid_send;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Dsp_Clear;
    }
}

