namespace SafeHome
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblSafeHome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.linkForgotPwd = new System.Windows.Forms.LinkLabel();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblLoginErr = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.pnlAddRoom = new System.Windows.Forms.Panel();
            this.lblAddSensor = new System.Windows.Forms.Label();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.comboAddSensor = new System.Windows.Forms.ComboBox();
            this.lbSensors = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.checkDoorS = new System.Windows.Forms.CheckBox();
            this.comboRoomS = new System.Windows.Forms.ComboBox();
            this.checkDoorE = new System.Windows.Forms.CheckBox();
            this.comboRoomE = new System.Windows.Forms.ComboBox();
            this.checkDoorW = new System.Windows.Forms.CheckBox();
            this.comboRoomW = new System.Windows.Forms.ComboBox();
            this.checkDoorN = new System.Windows.Forms.CheckBox();
            this.comboRoomN = new System.Windows.Forms.ComboBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.pnlViewRooms = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnLaunchEmulator = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.pnlAddRoom.SuspendLayout();
            this.pnlViewRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSafeHome
            // 
            this.lblSafeHome.AutoSize = true;
            this.lblSafeHome.Font = new System.Drawing.Font("American Typewriter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafeHome.Location = new System.Drawing.Point(12, 11);
            this.lblSafeHome.Name = "lblSafeHome";
            this.lblSafeHome.Size = new System.Drawing.Size(247, 37);
            this.lblSafeHome.TabIndex = 0;
            this.lblSafeHome.Text = "SafeHome v0.1";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(552, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 39);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLogin.Controls.Add(this.gbRegister);
            this.pnlLogin.Controls.Add(this.gbLogin);
            this.pnlLogin.Location = new System.Drawing.Point(19, 61);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(653, 218);
            this.pnlLogin.TabIndex = 6;
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.linkLabel1);
            this.gbRegister.Controls.Add(this.button3);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Controls.Add(this.textBox1);
            this.gbRegister.Controls.Add(this.label3);
            this.gbRegister.Controls.Add(this.textBox2);
            this.gbRegister.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegister.Location = new System.Drawing.Point(342, 3);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(299, 205);
            this.gbRegister.TabIndex = 5;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("American Typewriter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(62, 183);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(189, 14);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View our terms and conditions.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Password";
            this.textBox1.Location = new System.Drawing.Point(7, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(286, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "Username";
            this.textBox2.Location = new System.Drawing.Point(7, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 26);
            this.textBox2.TabIndex = 5;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.linkForgotPwd);
            this.gbLogin.Controls.Add(this.lblLoginError);
            this.gbLogin.Controls.Add(this.lblLoginErr);
            this.gbLogin.Controls.Add(this.btnSignIn);
            this.gbLogin.Controls.Add(this.lblLoginPwd);
            this.gbLogin.Controls.Add(this.lblLoginUsername);
            this.gbLogin.Controls.Add(this.txtLoginPwd);
            this.gbLogin.Controls.Add(this.txtLoginName);
            this.gbLogin.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(13, 4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(323, 204);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Log in";
            // 
            // linkForgotPwd
            // 
            this.linkForgotPwd.AutoSize = true;
            this.linkForgotPwd.Font = new System.Drawing.Font("American Typewriter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPwd.Location = new System.Drawing.Point(121, 182);
            this.linkForgotPwd.Name = "linkForgotPwd";
            this.linkForgotPwd.Size = new System.Drawing.Size(132, 14);
            this.linkForgotPwd.TabIndex = 9;
            this.linkForgotPwd.TabStop = true;
            this.linkForgotPwd.Text = "Forgotten Password?";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("American Typewriter", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.Location = new System.Drawing.Point(16, 132);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 13);
            this.lblLoginError.TabIndex = 6;
            // 
            // lblLoginErr
            // 
            this.lblLoginErr.AutoSize = true;
            this.lblLoginErr.Font = new System.Drawing.Font("American Typewriter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginErr.Location = new System.Drawing.Point(10, 127);
            this.lblLoginErr.Name = "lblLoginErr";
            this.lblLoginErr.Size = new System.Drawing.Size(0, 14);
            this.lblLoginErr.TabIndex = 5;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(140, 143);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(87, 36);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(7, 74);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(84, 19);
            this.lblLoginPwd.TabIndex = 3;
            this.lblLoginPwd.Text = "Password";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(7, 26);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(54, 19);
            this.lblLoginUsername.TabIndex = 2;
            this.lblLoginUsername.Text = "Email";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.AccessibleName = "Password";
            this.txtLoginPwd.Location = new System.Drawing.Point(6, 94);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(311, 26);
            this.txtLoginPwd.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.AccessibleName = "Username";
            this.txtLoginName.Location = new System.Drawing.Point(6, 45);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(311, 26);
            this.txtLoginName.TabIndex = 0;
            // 
            // pnlAddRoom
            // 
            this.pnlAddRoom.Controls.Add(this.lblAddSensor);
            this.pnlAddRoom.Controls.Add(this.btnDeleteSensor);
            this.pnlAddRoom.Controls.Add(this.label8);
            this.pnlAddRoom.Controls.Add(this.label7);
            this.pnlAddRoom.Controls.Add(this.label6);
            this.pnlAddRoom.Controls.Add(this.label5);
            this.pnlAddRoom.Controls.Add(this.btnAddSensor);
            this.pnlAddRoom.Controls.Add(this.comboAddSensor);
            this.pnlAddRoom.Controls.Add(this.lbSensors);
            this.pnlAddRoom.Controls.Add(this.btnSave);
            this.pnlAddRoom.Controls.Add(this.txtRoomName);
            this.pnlAddRoom.Controls.Add(this.checkDoorS);
            this.pnlAddRoom.Controls.Add(this.comboRoomS);
            this.pnlAddRoom.Controls.Add(this.checkDoorE);
            this.pnlAddRoom.Controls.Add(this.comboRoomE);
            this.pnlAddRoom.Controls.Add(this.checkDoorW);
            this.pnlAddRoom.Controls.Add(this.comboRoomW);
            this.pnlAddRoom.Controls.Add(this.checkDoorN);
            this.pnlAddRoom.Controls.Add(this.comboRoomN);
            this.pnlAddRoom.Controls.Add(this.lblRoomName);
            this.pnlAddRoom.Location = new System.Drawing.Point(18, 61);
            this.pnlAddRoom.Name = "pnlAddRoom";
            this.pnlAddRoom.Size = new System.Drawing.Size(654, 218);
            this.pnlAddRoom.TabIndex = 8;
            // 
            // lblAddSensor
            // 
            this.lblAddSensor.AutoSize = true;
            this.lblAddSensor.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSensor.Location = new System.Drawing.Point(373, 13);
            this.lblAddSensor.Name = "lblAddSensor";
            this.lblAddSensor.Size = new System.Drawing.Size(86, 12);
            this.lblAddSensor.TabIndex = 17;
            this.lblAddSensor.Text = "Add a sensor";
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.Font = new System.Drawing.Font("American Typewriter", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSensor.Location = new System.Drawing.Point(602, 29);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(40, 20);
            this.btnDeleteSensor.TabIndex = 16;
            this.btnDeleteSensor.Text = "Del";
            this.btnDeleteSensor.UseVisualStyleBackColor = true;
            this.btnDeleteSensor.Click += new System.EventHandler(this.btnDeleteSensor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "West Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "South Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "East Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "North Room";
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Font = new System.Drawing.Font("American Typewriter", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSensor.Location = new System.Drawing.Point(559, 29);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(38, 20);
            this.btnAddSensor.TabIndex = 9;
            this.btnAddSensor.Text = "Add";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // comboAddSensor
            // 
            this.comboAddSensor.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAddSensor.FormattingEnabled = true;
            this.comboAddSensor.Location = new System.Drawing.Point(372, 30);
            this.comboAddSensor.Name = "comboAddSensor";
            this.comboAddSensor.Size = new System.Drawing.Size(181, 20);
            this.comboAddSensor.TabIndex = 11;
            this.comboAddSensor.Text = "Add a sensor";
            // 
            // lbSensors
            // 
            this.lbSensors.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensors.FormattingEnabled = true;
            this.lbSensors.ItemHeight = 12;
            this.lbSensors.Location = new System.Drawing.Point(372, 59);
            this.lbSensors.Name = "lbSensors";
            this.lbSensors.Size = new System.Drawing.Size(270, 76);
            this.lbSensors.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(628, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(90, 11);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(231, 20);
            this.txtRoomName.TabIndex = 8;
            // 
            // checkDoorS
            // 
            this.checkDoorS.AutoSize = true;
            this.checkDoorS.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoorS.Location = new System.Drawing.Point(265, 90);
            this.checkDoorS.Name = "checkDoorS";
            this.checkDoorS.Size = new System.Drawing.Size(56, 16);
            this.checkDoorS.TabIndex = 7;
            this.checkDoorS.Text = "Door";
            this.checkDoorS.UseVisualStyleBackColor = true;
            // 
            // comboRoomS
            // 
            this.comboRoomS.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomS.FormattingEnabled = true;
            this.comboRoomS.Location = new System.Drawing.Point(90, 88);
            this.comboRoomS.Name = "comboRoomS";
            this.comboRoomS.Size = new System.Drawing.Size(169, 20);
            this.comboRoomS.TabIndex = 6;
            // 
            // checkDoorE
            // 
            this.checkDoorE.AutoSize = true;
            this.checkDoorE.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoorE.Location = new System.Drawing.Point(265, 64);
            this.checkDoorE.Name = "checkDoorE";
            this.checkDoorE.Size = new System.Drawing.Size(56, 16);
            this.checkDoorE.TabIndex = 5;
            this.checkDoorE.Text = "Door";
            this.checkDoorE.UseVisualStyleBackColor = true;
            // 
            // comboRoomE
            // 
            this.comboRoomE.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomE.FormattingEnabled = true;
            this.comboRoomE.Location = new System.Drawing.Point(90, 62);
            this.comboRoomE.Name = "comboRoomE";
            this.comboRoomE.Size = new System.Drawing.Size(169, 20);
            this.comboRoomE.TabIndex = 4;
            // 
            // checkDoorW
            // 
            this.checkDoorW.AutoSize = true;
            this.checkDoorW.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoorW.Location = new System.Drawing.Point(265, 117);
            this.checkDoorW.Name = "checkDoorW";
            this.checkDoorW.Size = new System.Drawing.Size(56, 16);
            this.checkDoorW.TabIndex = 3;
            this.checkDoorW.Text = "Door";
            this.checkDoorW.UseVisualStyleBackColor = true;
            // 
            // comboRoomW
            // 
            this.comboRoomW.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomW.FormattingEnabled = true;
            this.comboRoomW.Location = new System.Drawing.Point(90, 115);
            this.comboRoomW.Name = "comboRoomW";
            this.comboRoomW.Size = new System.Drawing.Size(169, 20);
            this.comboRoomW.TabIndex = 2;
            // 
            // checkDoorN
            // 
            this.checkDoorN.AutoSize = true;
            this.checkDoorN.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoorN.Location = new System.Drawing.Point(265, 38);
            this.checkDoorN.Name = "checkDoorN";
            this.checkDoorN.Size = new System.Drawing.Size(56, 16);
            this.checkDoorN.TabIndex = 1;
            this.checkDoorN.Text = "Door";
            this.checkDoorN.UseVisualStyleBackColor = true;
            // 
            // comboRoomN
            // 
            this.comboRoomN.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomN.FormattingEnabled = true;
            this.comboRoomN.Location = new System.Drawing.Point(90, 36);
            this.comboRoomN.Name = "comboRoomN";
            this.comboRoomN.Size = new System.Drawing.Size(169, 20);
            this.comboRoomN.TabIndex = 0;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(11, 13);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(73, 12);
            this.lblRoomName.TabIndex = 9;
            this.lblRoomName.Text = "Room Name";
            // 
            // pnlViewRooms
            // 
            this.pnlViewRooms.Controls.Add(this.btnAddRoom);
            this.pnlViewRooms.Location = new System.Drawing.Point(18, 61);
            this.pnlViewRooms.Name = "pnlViewRooms";
            this.pnlViewRooms.Size = new System.Drawing.Size(654, 218);
            this.pnlViewRooms.TabIndex = 7;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(603, 15);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(39, 39);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "+";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnLaunchEmulator
            // 
            this.btnLaunchEmulator.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchEmulator.Location = new System.Drawing.Point(393, 9);
            this.btnLaunchEmulator.Name = "btnLaunchEmulator";
            this.btnLaunchEmulator.Size = new System.Drawing.Size(153, 39);
            this.btnLaunchEmulator.TabIndex = 9;
            this.btnLaunchEmulator.Text = "Launch Emulator";
            this.btnLaunchEmulator.UseVisualStyleBackColor = true;
            this.btnLaunchEmulator.Click += new System.EventHandler(this.btnLaunchEmulator_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 281);
            this.Controls.Add(this.btnLaunchEmulator);
            this.Controls.Add(this.pnlAddRoom);
            this.Controls.Add(this.pnlViewRooms);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSafeHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "SafeHome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlLogin.ResumeLayout(false);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.pnlAddRoom.ResumeLayout(false);
            this.pnlAddRoom.PerformLayout();
            this.pnlViewRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSafeHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLoginErr;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Panel pnlAddRoom;
        private System.Windows.Forms.Panel pnlViewRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.CheckBox checkDoorS;
        private System.Windows.Forms.ComboBox comboRoomS;
        private System.Windows.Forms.CheckBox checkDoorE;
        private System.Windows.Forms.ComboBox comboRoomE;
        private System.Windows.Forms.CheckBox checkDoorW;
        private System.Windows.Forms.ComboBox comboRoomW;
        private System.Windows.Forms.CheckBox checkDoorN;
        private System.Windows.Forms.ComboBox comboRoomN;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.ListBox lbSensors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.ComboBox comboAddSensor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSensor;
        private System.Windows.Forms.LinkLabel linkForgotPwd;
        private System.Windows.Forms.Label lblAddSensor;
        private System.Windows.Forms.Button btnLaunchEmulator;
    }
}