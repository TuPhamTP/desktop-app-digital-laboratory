
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.timerReadPLCSIM = new System.Windows.Forms.Timer(this.components);
            this.timerMQTT = new System.Windows.Forms.Timer(this.components);
            this.timerWritePLCSIM = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSubmitID = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picEyeOff = new System.Windows.Forms.PictureBox();
            this.picEyeOn = new System.Windows.Forms.PictureBox();
            this.picConnectBrokerOFF = new System.Windows.Forms.PictureBox();
            this.picConnectBrokerON = new System.Windows.Forms.PictureBox();
            this.lblNotifyConnectBroker = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConnectBroker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtBrokerAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picConnectPLCOFF = new System.Windows.Forms.PictureBox();
            this.picConnectPLCON = new System.Windows.Forms.PictureBox();
            this.lblNotifyConnectPLC = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIPPLC = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picConnectPLCSIMOFF = new System.Windows.Forms.PictureBox();
            this.picConnectPLCSIMON = new System.Windows.Forms.PictureBox();
            this.lblNotifyConnectPLCSIM = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConnectPLCSIM = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIPPC = new System.Windows.Forms.TextBox();
            this.timerReadPLC = new System.Windows.Forms.Timer(this.components);
            this.timerWritePLC = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectBrokerOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectBrokerON)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCON)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCSIMOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCSIMON)).BeginInit();
            this.SuspendLayout();
            // 
            // timerConnect
            // 
            this.timerConnect.Interval = 10;
            this.timerConnect.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // timerReadPLCSIM
            // 
            this.timerReadPLCSIM.Tick += new System.EventHandler(this.timerReadPLCSIM_Tick);
            // 
            // timerMQTT
            // 
            this.timerMQTT.Tick += new System.EventHandler(this.timerMQTT_Tick);
            // 
            // timerWritePLCSIM
            // 
            this.timerWritePLCSIM.Tick += new System.EventHandler(this.timerWritePLCSIM_Tick);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Panel_638x179;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.btnSubmitID);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.lblID);
            this.panel5.Controls.Add(this.txtID);
            this.panel5.Location = new System.Drawing.Point(23, 456);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 179);
            this.panel5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(122, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "CÀI ĐẶT ID NGƯỜI DÙNG ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID:";
            // 
            // btnSubmitID
            // 
            this.btnSubmitID.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitID.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Button;
            this.btnSubmitID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitID.FlatAppearance.BorderSize = 0;
            this.btnSubmitID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmitID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitID.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitID.ForeColor = System.Drawing.Color.White;
            this.btnSubmitID.Location = new System.Drawing.Point(391, 87);
            this.btnSubmitID.Name = "btnSubmitID";
            this.btnSubmitID.Size = new System.Drawing.Size(180, 60);
            this.btnSubmitID.TabIndex = 2;
            this.btnSubmitID.Text = "GỬI ID";
            this.btnSubmitID.UseVisualStyleBackColor = false;
            this.btnSubmitID.Click += new System.EventHandler(this.btnSubmitID_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel9.Location = new System.Drawing.Point(27, 144);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 3);
            this.panel9.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.lblID.Location = new System.Drawing.Point(66, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 29);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "0";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(29, 118);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 28);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Panel_638x395;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picEyeOff);
            this.panel1.Controls.Add(this.picEyeOn);
            this.panel1.Controls.Add(this.picConnectBrokerOFF);
            this.panel1.Controls.Add(this.picConnectBrokerON);
            this.panel1.Controls.Add(this.lblNotifyConnectBroker);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnConnectBroker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtBrokerAddress);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(23, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 395);
            this.panel1.TabIndex = 0;
            // 
            // picEyeOff
            // 
            this.picEyeOff.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.eyes_pass_off;
            this.picEyeOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEyeOff.Location = new System.Drawing.Point(584, 236);
            this.picEyeOff.Name = "picEyeOff";
            this.picEyeOff.Size = new System.Drawing.Size(30, 18);
            this.picEyeOff.TabIndex = 8;
            this.picEyeOff.TabStop = false;
            this.picEyeOff.Click += new System.EventHandler(this.picEyeOff_Click);
            // 
            // picEyeOn
            // 
            this.picEyeOn.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.eyes_pass_on;
            this.picEyeOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEyeOn.Location = new System.Drawing.Point(584, 238);
            this.picEyeOn.Name = "picEyeOn";
            this.picEyeOn.Size = new System.Drawing.Size(30, 15);
            this.picEyeOn.TabIndex = 7;
            this.picEyeOn.TabStop = false;
            this.picEyeOn.Click += new System.EventHandler(this.picEyeOn_Click);
            // 
            // picConnectBrokerOFF
            // 
            this.picConnectBrokerOFF.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_OFF;
            this.picConnectBrokerOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectBrokerOFF.Location = new System.Drawing.Point(580, 31);
            this.picConnectBrokerOFF.Name = "picConnectBrokerOFF";
            this.picConnectBrokerOFF.Size = new System.Drawing.Size(30, 30);
            this.picConnectBrokerOFF.TabIndex = 6;
            this.picConnectBrokerOFF.TabStop = false;
            // 
            // picConnectBrokerON
            // 
            this.picConnectBrokerON.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_ON;
            this.picConnectBrokerON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectBrokerON.Location = new System.Drawing.Point(580, 31);
            this.picConnectBrokerON.Name = "picConnectBrokerON";
            this.picConnectBrokerON.Size = new System.Drawing.Size(30, 30);
            this.picConnectBrokerON.TabIndex = 5;
            this.picConnectBrokerON.TabStop = false;
            // 
            // lblNotifyConnectBroker
            // 
            this.lblNotifyConnectBroker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotifyConnectBroker.AutoSize = true;
            this.lblNotifyConnectBroker.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifyConnectBroker.Font = new System.Drawing.Font("Roboto Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyConnectBroker.ForeColor = System.Drawing.Color.White;
            this.lblNotifyConnectBroker.Location = new System.Drawing.Point(235, 71);
            this.lblNotifyConnectBroker.Name = "lblNotifyConnectBroker";
            this.lblNotifyConnectBroker.Size = new System.Drawing.Size(176, 17);
            this.lblNotifyConnectBroker.TabIndex = 1;
            this.lblNotifyConnectBroker.Text = "Kết nối không thành công! ";
            this.lblNotifyConnectBroker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNotifyConnectBroker.Click += new System.EventHandler(this.lblNotifyConnectBroker_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel8.Location = new System.Drawing.Point(363, 265);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 3);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel7.Location = new System.Drawing.Point(27, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 3);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel4.Location = new System.Drawing.Point(364, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 3);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(27, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 3);
            this.panel6.TabIndex = 4;
            // 
            // btnConnectBroker
            // 
            this.btnConnectBroker.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectBroker.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Button;
            this.btnConnectBroker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnectBroker.FlatAppearance.BorderSize = 0;
            this.btnConnectBroker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnectBroker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnectBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectBroker.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectBroker.ForeColor = System.Drawing.Color.Transparent;
            this.btnConnectBroker.Location = new System.Drawing.Point(231, 306);
            this.btnConnectBroker.Name = "btnConnectBroker";
            this.btnConnectBroker.Size = new System.Drawing.Size(180, 60);
            this.btnConnectBroker.TabIndex = 2;
            this.btnConnectBroker.Text = "KẾT NỐI";
            this.btnConnectBroker.UseVisualStyleBackColor = false;
            this.btnConnectBroker.Click += new System.EventHandler(this.btnConnectBroker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(358, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(56, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "THIẾT LẬP KẾT NỐI ĐẾN BROKER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ Broker:";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(365, 139);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(74, 28);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "1883";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(364, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 28);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "passwordmqtt2";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.Location = new System.Drawing.Point(29, 235);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "mqtt";
            // 
            // txtBrokerAddress
            // 
            this.txtBrokerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtBrokerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrokerAddress.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrokerAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBrokerAddress.Location = new System.Drawing.Point(29, 139);
            this.txtBrokerAddress.Name = "txtBrokerAddress";
            this.txtBrokerAddress.Size = new System.Drawing.Size(177, 28);
            this.txtBrokerAddress.TabIndex = 0;
            this.txtBrokerAddress.Text = "40.76.54.39";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Panel_556x210;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.picConnectPLCOFF);
            this.panel2.Controls.Add(this.picConnectPLCON);
            this.panel2.Controls.Add(this.lblNotifyConnectPLC);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnConnectPLC);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtIPPLC);
            this.panel2.Location = new System.Drawing.Point(682, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 210);
            this.panel2.TabIndex = 1;
            // 
            // picConnectPLCOFF
            // 
            this.picConnectPLCOFF.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_OFF;
            this.picConnectPLCOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectPLCOFF.Location = new System.Drawing.Point(510, 39);
            this.picConnectPLCOFF.Name = "picConnectPLCOFF";
            this.picConnectPLCOFF.Size = new System.Drawing.Size(30, 30);
            this.picConnectPLCOFF.TabIndex = 15;
            this.picConnectPLCOFF.TabStop = false;
            // 
            // picConnectPLCON
            // 
            this.picConnectPLCON.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_ON;
            this.picConnectPLCON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectPLCON.Location = new System.Drawing.Point(510, 39);
            this.picConnectPLCON.Name = "picConnectPLCON";
            this.picConnectPLCON.Size = new System.Drawing.Size(30, 30);
            this.picConnectPLCON.TabIndex = 14;
            this.picConnectPLCON.TabStop = false;
            // 
            // lblNotifyConnectPLC
            // 
            this.lblNotifyConnectPLC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotifyConnectPLC.AutoSize = true;
            this.lblNotifyConnectPLC.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifyConnectPLC.Font = new System.Drawing.Font("Roboto Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyConnectPLC.ForeColor = System.Drawing.Color.White;
            this.lblNotifyConnectPLC.Location = new System.Drawing.Point(204, 74);
            this.lblNotifyConnectPLC.Name = "lblNotifyConnectPLC";
            this.lblNotifyConnectPLC.Size = new System.Drawing.Size(176, 17);
            this.lblNotifyConnectPLC.TabIndex = 12;
            this.lblNotifyConnectPLC.Text = "Kết nối không thành công! ";
            this.lblNotifyConnectPLC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(28, 167);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 3);
            this.panel11.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(46, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(448, 39);
            this.label10.TabIndex = 9;
            this.label10.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLC";
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLC.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Button;
            this.btnConnectPLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnectPLC.FlatAppearance.BorderSize = 0;
            this.btnConnectPLC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectPLC.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPLC.ForeColor = System.Drawing.Color.White;
            this.btnConnectPLC.Location = new System.Drawing.Point(330, 110);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(180, 60);
            this.btnConnectPLC.TabIndex = 2;
            this.btnConnectPLC.Text = "KẾT NỐI";
            this.btnConnectPLC.UseVisualStyleBackColor = false;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ IP (PLC):";
            // 
            // txtIPPLC
            // 
            this.txtIPPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtIPPLC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPPLC.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPLC.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIPPLC.Location = new System.Drawing.Point(29, 139);
            this.txtIPPLC.Name = "txtIPPLC";
            this.txtIPPLC.Size = new System.Drawing.Size(145, 28);
            this.txtIPPLC.TabIndex = 0;
            this.txtIPPLC.Text = "192.168.0.1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel3.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Panel_556x210;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.picConnectPLCSIMOFF);
            this.panel3.Controls.Add(this.picConnectPLCSIMON);
            this.panel3.Controls.Add(this.lblNotifyConnectPLCSIM);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnConnectPLCSIM);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtIPPC);
            this.panel3.Location = new System.Drawing.Point(682, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 210);
            this.panel3.TabIndex = 1;
            // 
            // picConnectPLCSIMOFF
            // 
            this.picConnectPLCSIMOFF.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_OFF;
            this.picConnectPLCSIMOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectPLCSIMOFF.Location = new System.Drawing.Point(519, 32);
            this.picConnectPLCSIMOFF.Name = "picConnectPLCSIMOFF";
            this.picConnectPLCSIMOFF.Size = new System.Drawing.Size(30, 30);
            this.picConnectPLCSIMOFF.TabIndex = 14;
            this.picConnectPLCSIMOFF.TabStop = false;
            // 
            // picConnectPLCSIMON
            // 
            this.picConnectPLCSIMON.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Tick_ON;
            this.picConnectPLCSIMON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConnectPLCSIMON.Location = new System.Drawing.Point(519, 32);
            this.picConnectPLCSIMON.Name = "picConnectPLCSIMON";
            this.picConnectPLCSIMON.Size = new System.Drawing.Size(30, 30);
            this.picConnectPLCSIMON.TabIndex = 13;
            this.picConnectPLCSIMON.TabStop = false;
            // 
            // lblNotifyConnectPLCSIM
            // 
            this.lblNotifyConnectPLCSIM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotifyConnectPLCSIM.AutoSize = true;
            this.lblNotifyConnectPLCSIM.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifyConnectPLCSIM.Font = new System.Drawing.Font("Roboto Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyConnectPLCSIM.ForeColor = System.Drawing.Color.White;
            this.lblNotifyConnectPLCSIM.Location = new System.Drawing.Point(204, 71);
            this.lblNotifyConnectPLCSIM.Name = "lblNotifyConnectPLCSIM";
            this.lblNotifyConnectPLCSIM.Size = new System.Drawing.Size(176, 17);
            this.lblNotifyConnectPLCSIM.TabIndex = 12;
            this.lblNotifyConnectPLCSIM.Text = "Kết nối không thành công! ";
            this.lblNotifyConnectPLCSIM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Gradient_Green_Blue;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(26, 167);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 3);
            this.panel10.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Địa chỉ IP (PC):";
            // 
            // btnConnectPLCSIM
            // 
            this.btnConnectPLCSIM.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLCSIM.BackgroundImage = global::DesktopAppDigitalLab.Properties.Resources.Button;
            this.btnConnectPLCSIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnectPLCSIM.FlatAppearance.BorderSize = 0;
            this.btnConnectPLCSIM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLCSIM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnectPLCSIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectPLCSIM.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPLCSIM.ForeColor = System.Drawing.Color.White;
            this.btnConnectPLCSIM.Location = new System.Drawing.Point(330, 110);
            this.btnConnectPLCSIM.Name = "btnConnectPLCSIM";
            this.btnConnectPLCSIM.Size = new System.Drawing.Size(180, 60);
            this.btnConnectPLCSIM.TabIndex = 2;
            this.btnConnectPLCSIM.Text = "KẾT NỐI";
            this.btnConnectPLCSIM.UseVisualStyleBackColor = false;
            this.btnConnectPLCSIM.Click += new System.EventHandler(this.btnConnectPLCSIM_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(2, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(508, 39);
            this.label11.TabIndex = 8;
            this.label11.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLCSIM";
            // 
            // txtIPPC
            // 
            this.txtIPPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtIPPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPPC.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPC.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIPPC.Location = new System.Drawing.Point(26, 139);
            this.txtIPPC.Name = "txtIPPC";
            this.txtIPPC.Size = new System.Drawing.Size(145, 28);
            this.txtIPPC.TabIndex = 0;
            this.txtIPPC.Text = "192.168.0.10";
            // 
            // timerReadPLC
            // 
            this.timerReadPLC.Tick += new System.EventHandler(this.timerReadPLC_Tick);
            // 
            // timerWritePLC
            // 
            this.timerWritePLC.Tick += new System.EventHandler(this.timerWritePLC_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1258, 669);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Desktop App For Digital Laboratory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectBrokerOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectBrokerON)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCON)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCSIMOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectPLCSIMON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerConnect;
        private System.Windows.Forms.Timer timerReadPLCSIM;
        private System.Windows.Forms.Timer timerMQTT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.TextBox txtIPPLC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotifyConnectBroker;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSubmitID;
        private System.Windows.Forms.Button btnConnectBroker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtBrokerAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnectPLCSIM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIPPC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNotifyConnectPLCSIM;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblNotifyConnectPLC;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox picConnectBrokerON;
        private System.Windows.Forms.PictureBox picConnectPLCON;
        private System.Windows.Forms.PictureBox picConnectPLCSIMON;
        private System.Windows.Forms.PictureBox picConnectBrokerOFF;
        private System.Windows.Forms.PictureBox picConnectPLCSIMOFF;
        private System.Windows.Forms.PictureBox picConnectPLCOFF;
        private System.Windows.Forms.Timer timerWritePLCSIM;
        private System.Windows.Forms.PictureBox picEyeOn;
        private System.Windows.Forms.PictureBox picEyeOff;
        private System.Windows.Forms.Timer timerReadPLC;
        private System.Windows.Forms.Timer timerWritePLC;
    }
}

