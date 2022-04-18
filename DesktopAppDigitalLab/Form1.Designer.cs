
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.prgConnectMQTT = new System.Windows.Forms.ProgressBar();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNotifyConnectBroker = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmitID = new System.Windows.Forms.Button();
            this.btnConnectBroker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtBrokerAddress = new System.Windows.Forms.TextBox();
            this.txtIPPC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnectPLCSIM = new System.Windows.Forms.Button();
            this.prgConnectPLCSIM = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.prgConnectPLC = new System.Windows.Forms.ProgressBar();
            this.txtIPPLC = new System.Windows.Forms.TextBox();
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.timerTSample = new System.Windows.Forms.Timer(this.components);
            this.timerMQTT = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtErrorCode = new System.Windows.Forms.TextBox();
            this.txtSP1 = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.prgConnectMQTT);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnSubmitID);
            this.panel1.Controls.Add(this.btnConnectBroker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtBrokerAddress);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 399);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label12.Location = new System.Drawing.Point(273, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Trạng thái:";
            // 
            // prgConnectMQTT
            // 
            this.prgConnectMQTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.prgConnectMQTT.Location = new System.Drawing.Point(278, 178);
            this.prgConnectMQTT.Name = "prgConnectMQTT";
            this.prgConnectMQTT.Size = new System.Drawing.Size(145, 23);
            this.prgConnectMQTT.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel8.Location = new System.Drawing.Point(27, 270);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 2);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel7.Location = new System.Drawing.Point(27, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 2);
            this.panel7.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel10.Location = new System.Drawing.Point(27, 380);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 2);
            this.panel10.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel9.Location = new System.Drawing.Point(278, 127);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(150, 2);
            this.panel9.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel6.Location = new System.Drawing.Point(27, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel5.Controls.Add(this.lblNotifyConnectBroker);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 64);
            this.panel5.TabIndex = 3;
            // 
            // lblNotifyConnectBroker
            // 
            this.lblNotifyConnectBroker.AutoSize = true;
            this.lblNotifyConnectBroker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.lblNotifyConnectBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyConnectBroker.ForeColor = System.Drawing.Color.White;
            this.lblNotifyConnectBroker.Location = new System.Drawing.Point(128, 35);
            this.lblNotifyConnectBroker.Name = "lblNotifyConnectBroker";
            this.lblNotifyConnectBroker.Size = new System.Drawing.Size(203, 17);
            this.lblNotifyConnectBroker.TabIndex = 1;
            this.lblNotifyConnectBroker.Text = "Kết nối không thành công! ";
            this.lblNotifyConnectBroker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "THIẾT LẬP KẾT NỐI ĐẾN BROKER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmitID
            // 
            this.btnSubmitID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.btnSubmitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitID.ForeColor = System.Drawing.Color.White;
            this.btnSubmitID.Location = new System.Drawing.Point(293, 344);
            this.btnSubmitID.Name = "btnSubmitID";
            this.btnSubmitID.Size = new System.Drawing.Size(111, 41);
            this.btnSubmitID.TabIndex = 2;
            this.btnSubmitID.Text = "GỬI ID";
            this.btnSubmitID.UseVisualStyleBackColor = false;
            this.btnSubmitID.Click += new System.EventHandler(this.btnSubmitID_Click);
            // 
            // btnConnectBroker
            // 
            this.btnConnectBroker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.btnConnectBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectBroker.ForeColor = System.Drawing.Color.White;
            this.btnConnectBroker.Location = new System.Drawing.Point(293, 231);
            this.btnConnectBroker.Name = "btnConnectBroker";
            this.btnConnectBroker.Size = new System.Drawing.Size(111, 41);
            this.btnConnectBroker.TabIndex = 2;
            this.btnConnectBroker.Text = "KẾT NỐI";
            this.btnConnectBroker.UseVisualStyleBackColor = false;
            this.btnConnectBroker.Click += new System.EventHandler(this.btnConnectBroker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label4.Location = new System.Drawing.Point(23, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label13.Location = new System.Drawing.Point(23, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(273, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(28, 354);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ Broker:";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(278, 105);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(74, 20);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "1883";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(28, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "passwordmqtt2";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(28, 178);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "mqtt";
            // 
            // txtBrokerAddress
            // 
            this.txtBrokerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtBrokerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrokerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrokerAddress.ForeColor = System.Drawing.Color.White;
            this.txtBrokerAddress.Location = new System.Drawing.Point(27, 108);
            this.txtBrokerAddress.Name = "txtBrokerAddress";
            this.txtBrokerAddress.Size = new System.Drawing.Size(177, 20);
            this.txtBrokerAddress.TabIndex = 0;
            this.txtBrokerAddress.Text = "40.76.54.39";
            // 
            // txtIPPC
            // 
            this.txtIPPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtIPPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPC.ForeColor = System.Drawing.Color.White;
            this.txtIPPC.Location = new System.Drawing.Point(26, 105);
            this.txtIPPC.Name = "txtIPPC";
            this.txtIPPC.Size = new System.Drawing.Size(145, 20);
            this.txtIPPC.TabIndex = 0;
            this.txtIPPC.Text = "192.168.0.10";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.btnConnectPLCSIM);
            this.panel2.Controls.Add(this.prgConnectPLCSIM);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtIPPC);
            this.panel2.Location = new System.Drawing.Point(491, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 187);
            this.panel2.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel12.Location = new System.Drawing.Point(26, 127);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(160, 2);
            this.panel12.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(420, 65);
            this.panel11.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLCSIM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConnectPLCSIM
            // 
            this.btnConnectPLCSIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.btnConnectPLCSIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPLCSIM.ForeColor = System.Drawing.Color.White;
            this.btnConnectPLCSIM.Location = new System.Drawing.Point(165, 138);
            this.btnConnectPLCSIM.Name = "btnConnectPLCSIM";
            this.btnConnectPLCSIM.Size = new System.Drawing.Size(111, 41);
            this.btnConnectPLCSIM.TabIndex = 2;
            this.btnConnectPLCSIM.Text = "KẾT NỐI";
            this.btnConnectPLCSIM.UseVisualStyleBackColor = false;
            this.btnConnectPLCSIM.Click += new System.EventHandler(this.btnConnectPLCSIM_Click);
            // 
            // prgConnectPLCSIM
            // 
            this.prgConnectPLCSIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.prgConnectPLCSIM.Location = new System.Drawing.Point(249, 109);
            this.prgConnectPLCSIM.Name = "prgConnectPLCSIM";
            this.prgConnectPLCSIM.Size = new System.Drawing.Size(145, 23);
            this.prgConnectPLCSIM.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label8.Location = new System.Drawing.Point(243, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label7.Location = new System.Drawing.Point(21, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ IP (PC):";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.btnConnectPLC);
            this.panel3.Controls.Add(this.prgConnectPLC);
            this.panel3.Controls.Add(this.txtIPPLC);
            this.panel3.Location = new System.Drawing.Point(491, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 187);
            this.panel3.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel14.Location = new System.Drawing.Point(26, 126);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(160, 2);
            this.panel14.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label9.Location = new System.Drawing.Point(244, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label10.Location = new System.Drawing.Point(21, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Địa chỉ IP (PLC):";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.panel13.Controls.Add(this.label11);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(420, 65);
            this.panel13.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(57, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "THIẾT LẬP KẾT NỐI ĐẾN PLC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.btnConnectPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPLC.ForeColor = System.Drawing.Color.White;
            this.btnConnectPLC.Location = new System.Drawing.Point(165, 138);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(111, 41);
            this.btnConnectPLC.TabIndex = 2;
            this.btnConnectPLC.Text = "KẾT NỐI";
            this.btnConnectPLC.UseVisualStyleBackColor = false;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // prgConnectPLC
            // 
            this.prgConnectPLC.Location = new System.Drawing.Point(249, 105);
            this.prgConnectPLC.Name = "prgConnectPLC";
            this.prgConnectPLC.Size = new System.Drawing.Size(145, 23);
            this.prgConnectPLC.TabIndex = 2;
            // 
            // txtIPPLC
            // 
            this.txtIPPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtIPPLC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPLC.ForeColor = System.Drawing.Color.White;
            this.txtIPPLC.Location = new System.Drawing.Point(26, 104);
            this.txtIPPLC.Name = "txtIPPLC";
            this.txtIPPLC.Size = new System.Drawing.Size(145, 20);
            this.txtIPPLC.TabIndex = 0;
            this.txtIPPLC.Text = "192.168.0.1";
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
            // timerMQTT
            // 
            this.timerMQTT.Tick += new System.EventHandler(this.timerMQTT_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.txtErrorCode);
            this.panel4.Controls.Add(this.txtSP1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 555);
            this.panel4.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(158)))));
            this.lblID.Location = new System.Drawing.Point(183, 327);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 25);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "0";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.Location = new System.Drawing.Point(704, 462);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(217, 22);
            this.txtErrorCode.TabIndex = 2;
            this.txtErrorCode.TextChanged += new System.EventHandler(this.txtErrorCode_TextChanged);
            // 
            // txtSP1
            // 
            this.txtSP1.Location = new System.Drawing.Point(704, 502);
            this.txtSP1.Name = "txtSP1";
            this.txtSP1.Size = new System.Drawing.Size(217, 22);
            this.txtSP1.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(652, 442);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(278, 100);
            this.panel15.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Desktop App For Digital Laboratory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIPPC;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.ProgressBar prgConnectPLC;
        private System.Windows.Forms.TextBox txtIPPLC;
        private System.Windows.Forms.Timer timerConnect;
        private System.Windows.Forms.Timer timerTSample;
        private System.Windows.Forms.Timer timerMQTT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar prgConnectMQTT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtErrorCode;
        private System.Windows.Forms.TextBox txtSP1;
    }
}

