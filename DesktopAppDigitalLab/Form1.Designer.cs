
namespace DesktopAppDigitalLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmitID = new System.Windows.Forms.Button();
            this.btnConnectBroker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNotifyConnectBroker = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtBrokerAddress = new System.Windows.Forms.TextBox();
            this.txtIPPC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnectPLCSIM = new System.Windows.Forms.Button();
            this.prgConnectPLCSIM = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.prgConnectPLC = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIPPLC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtErrorCode = new System.Windows.Forms.TextBox();
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.timerTSample = new System.Windows.Forms.Timer(this.components);
            this.txtSP1 = new System.Windows.Forms.TextBox();
            this.timerMQTT = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnSubmitID);
            this.panel1.Controls.Add(this.btnConnectBroker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblNotifyConnectBroker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtBrokerAddress);
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 249);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmitID
            // 
            this.btnSubmitID.Location = new System.Drawing.Point(325, 197);
            this.btnSubmitID.Name = "btnSubmitID";
            this.btnSubmitID.Size = new System.Drawing.Size(111, 25);
            this.btnSubmitID.TabIndex = 2;
            this.btnSubmitID.Text = "GỬI";
            this.btnSubmitID.UseVisualStyleBackColor = true;
            this.btnSubmitID.Click += new System.EventHandler(this.btnSubmitID_Click);
            // 
            // btnConnectBroker
            // 
            this.btnConnectBroker.Location = new System.Drawing.Point(325, 116);
            this.btnConnectBroker.Name = "btnConnectBroker";
            this.btnConnectBroker.Size = new System.Drawing.Size(111, 62);
            this.btnConnectBroker.TabIndex = 2;
            this.btnConnectBroker.Text = "KẾT NỐI";
            this.btnConnectBroker.UseVisualStyleBackColor = true;
            this.btnConnectBroker.Click += new System.EventHandler(this.btnConnectBroker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 198);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblNotifyConnectBroker
            // 
            this.lblNotifyConnectBroker.AutoSize = true;
            this.lblNotifyConnectBroker.Location = new System.Drawing.Point(128, 30);
            this.lblNotifyConnectBroker.Name = "lblNotifyConnectBroker";
            this.lblNotifyConnectBroker.Size = new System.Drawing.Size(177, 17);
            this.lblNotifyConnectBroker.TabIndex = 1;
            this.lblNotifyConnectBroker.Text = "Kết nối không thành công! ";
            this.lblNotifyConnectBroker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "THIẾT LẬP KẾT NỐI ĐẾN BROKER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ Broker";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(362, 74);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(74, 22);
            this.txtPort.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 22);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 116);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtBrokerAddress
            // 
            this.txtBrokerAddress.Location = new System.Drawing.Point(130, 74);
            this.txtBrokerAddress.Name = "txtBrokerAddress";
            this.txtBrokerAddress.Size = new System.Drawing.Size(177, 22);
            this.txtBrokerAddress.TabIndex = 0;
            // 
            // txtIPPC
            // 
            this.txtIPPC.Location = new System.Drawing.Point(131, 44);
            this.txtIPPC.Name = "txtIPPC";
            this.txtIPPC.Size = new System.Drawing.Size(145, 22);
            this.txtIPPC.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.btnConnectPLCSIM);
            this.panel2.Controls.Add(this.prgConnectPLCSIM);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtIPPC);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(504, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 120);
            this.panel2.TabIndex = 1;
            // 
            // btnConnectPLCSIM
            // 
            this.btnConnectPLCSIM.Location = new System.Drawing.Point(299, 44);
            this.btnConnectPLCSIM.Name = "btnConnectPLCSIM";
            this.btnConnectPLCSIM.Size = new System.Drawing.Size(111, 62);
            this.btnConnectPLCSIM.TabIndex = 2;
            this.btnConnectPLCSIM.Text = "KẾT NỐI";
            this.btnConnectPLCSIM.UseVisualStyleBackColor = true;
            this.btnConnectPLCSIM.Click += new System.EventHandler(this.btnConnectPLCSIM_Click);
            // 
            // prgConnectPLCSIM
            // 
            this.prgConnectPLCSIM.Location = new System.Drawing.Point(131, 83);
            this.prgConnectPLCSIM.Name = "prgConnectPLCSIM";
            this.prgConnectPLCSIM.Size = new System.Drawing.Size(145, 23);
            this.prgConnectPLCSIM.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ IP (PC)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLCSIM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.btnConnectPLC);
            this.panel3.Controls.Add(this.prgConnectPLC);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtIPPLC);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(504, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 120);
            this.panel3.TabIndex = 1;
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.Location = new System.Drawing.Point(299, 44);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(111, 62);
            this.btnConnectPLC.TabIndex = 2;
            this.btnConnectPLC.Text = "KẾT NỐI";
            this.btnConnectPLC.UseVisualStyleBackColor = true;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // prgConnectPLC
            // 
            this.prgConnectPLC.Location = new System.Drawing.Point(131, 83);
            this.prgConnectPLC.Name = "prgConnectPLC";
            this.prgConnectPLC.Size = new System.Drawing.Size(145, 23);
            this.prgConnectPLC.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Trạng thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa chỉ IP (PLC)";
            // 
            // txtIPPLC
            // 
            this.txtIPPLC.Location = new System.Drawing.Point(131, 44);
            this.txtIPPLC.Name = "txtIPPLC";
            this.txtIPPLC.Size = new System.Drawing.Size(145, 22);
            this.txtIPPLC.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLC";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.Location = new System.Drawing.Point(704, 300);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(217, 22);
            this.txtErrorCode.TabIndex = 2;
            // 
            // timerConnect
            // 
            this.timerConnect.Interval = 10;
            this.timerConnect.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // timerTSample
            // 
            this.timerTSample.Tick += new System.EventHandler(this.timerTSample_Tick);
            // 
            // txtSP1
            // 
            this.txtSP1.Location = new System.Drawing.Point(704, 337);
            this.txtSP1.Name = "txtSP1";
            this.txtSP1.Size = new System.Drawing.Size(217, 22);
            this.txtSP1.TabIndex = 2;
            // 
            // timerMQTT
            // 
            this.timerMQTT.Tick += new System.EventHandler(this.timerMQTT_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.txtSP1);
            this.Controls.Add(this.txtErrorCode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIPPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtBrokerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmitID;
        private System.Windows.Forms.Button btnConnectBroker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNotifyConnectBroker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnectPLCSIM;
        private System.Windows.Forms.ProgressBar prgConnectPLCSIM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.ProgressBar prgConnectPLC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIPPLC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtErrorCode;
        private System.Windows.Forms.Timer timerConnect;
        private System.Windows.Forms.Timer timerTSample;
        private System.Windows.Forms.TextBox txtSP1;
        private System.Windows.Forms.Timer timerMQTT;
    }
}

