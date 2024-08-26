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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_RxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click_1);
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
            this.groupBox_RxFormat.Location = new System.Drawing.Point(7, 328);
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
            this.CB_Enable_Terminal.Location = new System.Drawing.Point(262, 181);
            this.CB_Enable_Terminal.Name = "CB_Enable_Terminal";
            this.CB_Enable_Terminal.Size = new System.Drawing.Size(117, 16);
            this.CB_Enable_Terminal.TabIndex = 40;
            this.CB_Enable_Terminal.Text = "Enable Terminal";
            this.CB_Enable_Terminal.UseVisualStyleBackColor = true;
            this.CB_Enable_Terminal.CheckedChanged += new System.EventHandler(this.CB_Enable_Terminal_CheckedChanged);
            // 
            // TextBox_received
            // 
            this.TextBox_received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_received.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_received.Location = new System.Drawing.Point(96, 203);
            this.TextBox_received.Multiline = true;
            this.TextBox_received.Name = "TextBox_received";
            this.TextBox_received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received.Size = new System.Drawing.Size(297, 195);
            this.TextBox_received.TabIndex = 39;
            this.TextBox_received.TextChanged += new System.EventHandler(this.TextBox_received_TextChanged);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(94, 404);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(204, 21);
            this.textBox_send.TabIndex = 36;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_send_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(304, 403);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 37;
            this.button_send.Text = "보내기";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click_1);
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Location = new System.Drawing.Point(61, 407);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 12);
            this.label_send.TabIndex = 38;
            this.label_send.Text = "송신";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 312);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(404, 437);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial_Communication";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 374);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ball_Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_RxFormat.ResumeLayout(false);
            this.groupBox_RxFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

