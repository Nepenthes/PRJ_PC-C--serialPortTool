namespace WindowsFormsApplication_serialTest
{
    partial class Form_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort_A = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_serialOpenIF = new System.Windows.Forms.Button();
            this.comboBox_dataBit = new System.Windows.Forms.ComboBox();
            this.comboBox_stopBit = new System.Windows.Forms.ComboBox();
            this.comboBox_checkBit = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_serialNum = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_dataSendDispByASCII = new System.Windows.Forms.RadioButton();
            this.textBox_dataSend = new System.Windows.Forms.TextBox();
            this.radioButton_dataSendDispByHEX = new System.Windows.Forms.RadioButton();
            this.button_dataSendBuffer_clear = new System.Windows.Forms.Button();
            this.button_dataSend = new System.Windows.Forms.Button();
            this.groupBox_dataRcv = new System.Windows.Forms.GroupBox();
            this.button_dataRcvBuffer_clear = new System.Windows.Forms.Button();
            this.radioButton_dataRcvDispByASCII = new System.Windows.Forms.RadioButton();
            this.radioButton_dataRcvDispByHEX = new System.Windows.Forms.RadioButton();
            this.textBox_dataRcv = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_dataRcv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_serialOpenIF);
            this.groupBox3.Controls.Add(this.comboBox_dataBit);
            this.groupBox3.Controls.Add(this.comboBox_stopBit);
            this.groupBox3.Controls.Add(this.comboBox_checkBit);
            this.groupBox3.Controls.Add(this.comboBox_baud);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox_serialNum);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(335, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 216);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置区";
            // 
            // button_serialOpenIF
            // 
            this.button_serialOpenIF.Location = new System.Drawing.Point(22, 156);
            this.button_serialOpenIF.Name = "button_serialOpenIF";
            this.button_serialOpenIF.Size = new System.Drawing.Size(138, 40);
            this.button_serialOpenIF.TabIndex = 8;
            this.button_serialOpenIF.Text = "打开串口";
            this.button_serialOpenIF.UseVisualStyleBackColor = true;
            this.button_serialOpenIF.Click += new System.EventHandler(this.button_serialOpenIF_Click);
            // 
            // comboBox_dataBit
            // 
            this.comboBox_dataBit.FormattingEnabled = true;
            this.comboBox_dataBit.Location = new System.Drawing.Point(59, 112);
            this.comboBox_dataBit.Name = "comboBox_dataBit";
            this.comboBox_dataBit.Size = new System.Drawing.Size(101, 20);
            this.comboBox_dataBit.TabIndex = 12;
            this.comboBox_dataBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_dataBit_SelectedIndexChanged);
            // 
            // comboBox_stopBit
            // 
            this.comboBox_stopBit.FormattingEnabled = true;
            this.comboBox_stopBit.Location = new System.Drawing.Point(59, 89);
            this.comboBox_stopBit.Name = "comboBox_stopBit";
            this.comboBox_stopBit.Size = new System.Drawing.Size(101, 20);
            this.comboBox_stopBit.TabIndex = 11;
            this.comboBox_stopBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_stopBit_SelectedIndexChanged);
            // 
            // comboBox_checkBit
            // 
            this.comboBox_checkBit.FormattingEnabled = true;
            this.comboBox_checkBit.Location = new System.Drawing.Point(59, 66);
            this.comboBox_checkBit.Name = "comboBox_checkBit";
            this.comboBox_checkBit.Size = new System.Drawing.Size(101, 20);
            this.comboBox_checkBit.TabIndex = 10;
            this.comboBox_checkBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_checkBit_SelectedIndexChanged);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(59, 43);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(101, 20);
            this.comboBox_baud.TabIndex = 9;
            this.comboBox_baud.SelectedIndexChanged += new System.EventHandler(this.comboBox_baud_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "校验位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "串口号：";
            // 
            // comboBox_serialNum
            // 
            this.comboBox_serialNum.FormattingEnabled = true;
            this.comboBox_serialNum.Location = new System.Drawing.Point(59, 20);
            this.comboBox_serialNum.Name = "comboBox_serialNum";
            this.comboBox_serialNum.Size = new System.Drawing.Size(101, 20);
            this.comboBox_serialNum.TabIndex = 3;
            this.comboBox_serialNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_serialNum_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_dataSendDispByASCII);
            this.groupBox2.Controls.Add(this.textBox_dataSend);
            this.groupBox2.Controls.Add(this.radioButton_dataSendDispByHEX);
            this.groupBox2.Controls.Add(this.button_dataSendBuffer_clear);
            this.groupBox2.Controls.Add(this.button_dataSend);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 216);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据发送区";
            // 
            // radioButton_dataSendDispByASCII
            // 
            this.radioButton_dataSendDispByASCII.AutoSize = true;
            this.radioButton_dataSendDispByASCII.Location = new System.Drawing.Point(87, 194);
            this.radioButton_dataSendDispByASCII.Name = "radioButton_dataSendDispByASCII";
            this.radioButton_dataSendDispByASCII.Size = new System.Drawing.Size(77, 16);
            this.radioButton_dataSendDispByASCII.TabIndex = 4;
            this.radioButton_dataSendDispByASCII.TabStop = true;
            this.radioButton_dataSendDispByASCII.Text = "ASCII显示";
            this.radioButton_dataSendDispByASCII.UseVisualStyleBackColor = true;
            this.radioButton_dataSendDispByASCII.CheckedChanged += new System.EventHandler(this.radioButton_dataSendDispByASCII_CheckedChanged);
            // 
            // textBox_dataSend
            // 
            this.textBox_dataSend.Location = new System.Drawing.Point(6, 20);
            this.textBox_dataSend.Multiline = true;
            this.textBox_dataSend.Name = "textBox_dataSend";
            this.textBox_dataSend.Size = new System.Drawing.Size(213, 168);
            this.textBox_dataSend.TabIndex = 8;
            this.textBox_dataSend.TextChanged += new System.EventHandler(this.textBox_dataSend_TextChanged);
            // 
            // radioButton_dataSendDispByHEX
            // 
            this.radioButton_dataSendDispByHEX.AutoSize = true;
            this.radioButton_dataSendDispByHEX.Location = new System.Drawing.Point(6, 194);
            this.radioButton_dataSendDispByHEX.Name = "radioButton_dataSendDispByHEX";
            this.radioButton_dataSendDispByHEX.Size = new System.Drawing.Size(65, 16);
            this.radioButton_dataSendDispByHEX.TabIndex = 7;
            this.radioButton_dataSendDispByHEX.TabStop = true;
            this.radioButton_dataSendDispByHEX.Text = "HEX显示";
            this.radioButton_dataSendDispByHEX.UseVisualStyleBackColor = true;
            this.radioButton_dataSendDispByHEX.CheckedChanged += new System.EventHandler(this.radioButton_dataSendDispByHEX_CheckedChanged);
            // 
            // button_dataSendBuffer_clear
            // 
            this.button_dataSendBuffer_clear.Location = new System.Drawing.Point(236, 165);
            this.button_dataSendBuffer_clear.Name = "button_dataSendBuffer_clear";
            this.button_dataSendBuffer_clear.Size = new System.Drawing.Size(75, 23);
            this.button_dataSendBuffer_clear.TabIndex = 6;
            this.button_dataSendBuffer_clear.Text = "清空内容";
            this.button_dataSendBuffer_clear.UseVisualStyleBackColor = true;
            this.button_dataSendBuffer_clear.Click += new System.EventHandler(this.button_dataSendBuffer_clear_Click);
            // 
            // button_dataSend
            // 
            this.button_dataSend.Location = new System.Drawing.Point(236, 115);
            this.button_dataSend.Name = "button_dataSend";
            this.button_dataSend.Size = new System.Drawing.Size(75, 23);
            this.button_dataSend.TabIndex = 5;
            this.button_dataSend.Text = "发送";
            this.button_dataSend.UseVisualStyleBackColor = true;
            this.button_dataSend.Click += new System.EventHandler(this.button_dataSend_Click);
            // 
            // groupBox_dataRcv
            // 
            this.groupBox_dataRcv.Controls.Add(this.button_dataRcvBuffer_clear);
            this.groupBox_dataRcv.Controls.Add(this.radioButton_dataRcvDispByASCII);
            this.groupBox_dataRcv.Controls.Add(this.radioButton_dataRcvDispByHEX);
            this.groupBox_dataRcv.Controls.Add(this.textBox_dataRcv);
            this.groupBox_dataRcv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_dataRcv.Location = new System.Drawing.Point(12, 12);
            this.groupBox_dataRcv.Name = "groupBox_dataRcv";
            this.groupBox_dataRcv.Size = new System.Drawing.Size(498, 178);
            this.groupBox_dataRcv.TabIndex = 3;
            this.groupBox_dataRcv.TabStop = false;
            this.groupBox_dataRcv.Text = "数据接收区";
            // 
            // button_dataRcvBuffer_clear
            // 
            this.button_dataRcvBuffer_clear.Location = new System.Drawing.Point(408, 146);
            this.button_dataRcvBuffer_clear.Name = "button_dataRcvBuffer_clear";
            this.button_dataRcvBuffer_clear.Size = new System.Drawing.Size(75, 26);
            this.button_dataRcvBuffer_clear.TabIndex = 10;
            this.button_dataRcvBuffer_clear.Text = "内容清空";
            this.button_dataRcvBuffer_clear.UseVisualStyleBackColor = true;
            this.button_dataRcvBuffer_clear.Click += new System.EventHandler(this.button_dataRcvBuffer_clear_Click);
            // 
            // radioButton_dataRcvDispByASCII
            // 
            this.radioButton_dataRcvDispByASCII.AutoSize = true;
            this.radioButton_dataRcvDispByASCII.Location = new System.Drawing.Point(87, 151);
            this.radioButton_dataRcvDispByASCII.Name = "radioButton_dataRcvDispByASCII";
            this.radioButton_dataRcvDispByASCII.Size = new System.Drawing.Size(77, 16);
            this.radioButton_dataRcvDispByASCII.TabIndex = 3;
            this.radioButton_dataRcvDispByASCII.TabStop = true;
            this.radioButton_dataRcvDispByASCII.Text = "ASCII显示";
            this.radioButton_dataRcvDispByASCII.UseVisualStyleBackColor = true;
            this.radioButton_dataRcvDispByASCII.CheckedChanged += new System.EventHandler(this.radioButton_dataRcvDispByASCII_CheckedChanged);
            // 
            // radioButton_dataRcvDispByHEX
            // 
            this.radioButton_dataRcvDispByHEX.AutoSize = true;
            this.radioButton_dataRcvDispByHEX.Location = new System.Drawing.Point(6, 151);
            this.radioButton_dataRcvDispByHEX.Name = "radioButton_dataRcvDispByHEX";
            this.radioButton_dataRcvDispByHEX.Size = new System.Drawing.Size(65, 16);
            this.radioButton_dataRcvDispByHEX.TabIndex = 2;
            this.radioButton_dataRcvDispByHEX.TabStop = true;
            this.radioButton_dataRcvDispByHEX.Text = "HEX显示";
            this.radioButton_dataRcvDispByHEX.UseVisualStyleBackColor = true;
            this.radioButton_dataRcvDispByHEX.CheckedChanged += new System.EventHandler(this.radioButton_dataRcvDispByHEX_CheckedChanged);
            // 
            // textBox_dataRcv
            // 
            this.textBox_dataRcv.Location = new System.Drawing.Point(6, 20);
            this.textBox_dataRcv.Multiline = true;
            this.textBox_dataRcv.Name = "textBox_dataRcv";
            this.textBox_dataRcv.ReadOnly = true;
            this.textBox_dataRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_dataRcv.Size = new System.Drawing.Size(486, 121);
            this.textBox_dataRcv.TabIndex = 1;
            this.textBox_dataRcv.TextChanged += new System.EventHandler(this.textBox_dataRcv_TextChanged);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(522, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_dataRcv);
            this.Name = "Form_main";
            this.Text = "串口助手_练手版^.^";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_dataRcv.ResumeLayout(false);
            this.groupBox_dataRcv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_A;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_serialOpenIF;
        private System.Windows.Forms.ComboBox comboBox_dataBit;
        private System.Windows.Forms.ComboBox comboBox_stopBit;
        private System.Windows.Forms.ComboBox comboBox_checkBit;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_serialNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_dataSendDispByHEX;
        private System.Windows.Forms.Button button_dataSendBuffer_clear;
        private System.Windows.Forms.Button button_dataSend;
        private System.Windows.Forms.GroupBox groupBox_dataRcv;
        private System.Windows.Forms.RadioButton radioButton_dataRcvDispByHEX;
        private System.Windows.Forms.TextBox textBox_dataRcv;
        private System.Windows.Forms.TextBox textBox_dataSend;
        private System.Windows.Forms.RadioButton radioButton_dataSendDispByASCII;
        private System.Windows.Forms.RadioButton radioButton_dataRcvDispByASCII;
        private System.Windows.Forms.Button button_dataRcvBuffer_clear;
    }
}

