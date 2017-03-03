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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblSafeHome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.lblRegisterError = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginErr = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.pnlAddRoom = new System.Windows.Forms.Panel();
            this.lbSensors = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSaveRoomError = new System.Windows.Forms.Label();
            this.lblAddSensor = new System.Windows.Forms.Label();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.comboAddSensor = new System.Windows.Forms.ComboBox();
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
            this.lblRoomCount = new System.Windows.Forms.Label();
            this.lblAddRoomError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddFloorError = new System.Windows.Forms.Label();
            this.btnAddFloor = new System.Windows.Forms.Button();
            this.comboFloorNum = new System.Windows.Forms.ComboBox();
            this.comboNoOfRooms = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.comboSelectFloor = new System.Windows.Forms.ComboBox();
            this.btnViewRoom = new System.Windows.Forms.Button();
            this.lblRooms = new System.Windows.Forms.Label();
            this.listboxRooms = new System.Windows.Forms.ListBox();
            this.pDCRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.safeHomeDataSet = new SafeHome.SafeHomeDataSet();
            this.btnLaunchEmulator = new System.Windows.Forms.Button();
            this.pDCSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDC_SensorTableAdapter = new SafeHome.SafeHomeDataSetTableAdapters.PDC_SensorTableAdapter();
            this.pDCRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDC_RoomTableAdapter = new SafeHome.SafeHomeDataSetTableAdapters.PDC_RoomTableAdapter();
            this.pnlLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.pnlAddRoom.SuspendLayout();
            this.pnlViewRooms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDCRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCSensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCRoomBindingSource)).BeginInit();
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
            this.gbRegister.Controls.Add(this.lblRegisterError);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Controls.Add(this.txtRegisterPwd);
            this.gbRegister.Controls.Add(this.label3);
            this.gbRegister.Controls.Add(this.txtRegisterName);
            this.gbRegister.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegister.Location = new System.Drawing.Point(342, 3);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(299, 205);
            this.gbRegister.TabIndex = 5;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // lblRegisterError
            // 
            this.lblRegisterError.AutoSize = true;
            this.lblRegisterError.Font = new System.Drawing.Font("American Typewriter", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterError.Location = new System.Drawing.Point(9, 128);
            this.lblRegisterError.Name = "lblRegisterError";
            this.lblRegisterError.Size = new System.Drawing.Size(0, 13);
            this.lblRegisterError.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(118, 144);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 36);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // txtRegisterPwd
            // 
            this.txtRegisterPwd.AccessibleName = "Password";
            this.txtRegisterPwd.Location = new System.Drawing.Point(7, 94);
            this.txtRegisterPwd.Name = "txtRegisterPwd";
            this.txtRegisterPwd.PasswordChar = '*';
            this.txtRegisterPwd.Size = new System.Drawing.Size(286, 26);
            this.txtRegisterPwd.TabIndex = 6;
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
            // txtRegisterName
            // 
            this.txtRegisterName.AccessibleName = "Username";
            this.txtRegisterName.Location = new System.Drawing.Point(7, 45);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(286, 26);
            this.txtRegisterName.TabIndex = 5;
            // 
            // gbLogin
            // 
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
            // lblLoginErr
            // 
            this.lblLoginErr.AutoSize = true;
            this.lblLoginErr.Font = new System.Drawing.Font("American Typewriter", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginErr.Location = new System.Drawing.Point(10, 127);
            this.lblLoginErr.Name = "lblLoginErr";
            this.lblLoginErr.Size = new System.Drawing.Size(0, 13);
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
            this.txtLoginPwd.AcceptsReturn = true;
            this.txtLoginPwd.AccessibleName = "Password";
            this.txtLoginPwd.Location = new System.Drawing.Point(6, 94);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(311, 26);
            this.txtLoginPwd.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.AcceptsReturn = true;
            this.txtLoginName.AccessibleName = "Username";
            this.txtLoginName.Location = new System.Drawing.Point(6, 45);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(311, 26);
            this.txtLoginName.TabIndex = 0;
            // 
            // pnlAddRoom
            // 
            this.pnlAddRoom.Controls.Add(this.lbSensors);
            this.pnlAddRoom.Controls.Add(this.btnCancel);
            this.pnlAddRoom.Controls.Add(this.lblSaveRoomError);
            this.pnlAddRoom.Controls.Add(this.lblAddSensor);
            this.pnlAddRoom.Controls.Add(this.btnDeleteSensor);
            this.pnlAddRoom.Controls.Add(this.label8);
            this.pnlAddRoom.Controls.Add(this.label7);
            this.pnlAddRoom.Controls.Add(this.label6);
            this.pnlAddRoom.Controls.Add(this.label5);
            this.pnlAddRoom.Controls.Add(this.btnAddSensor);
            this.pnlAddRoom.Controls.Add(this.comboAddSensor);
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
            this.pnlAddRoom.Location = new System.Drawing.Point(19, 61);
            this.pnlAddRoom.Name = "pnlAddRoom";
            this.pnlAddRoom.Size = new System.Drawing.Size(654, 218);
            this.pnlAddRoom.TabIndex = 8;
            // 
            // lbSensors
            // 
            this.lbSensors.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensors.FormattingEnabled = true;
            this.lbSensors.ItemHeight = 12;
            this.lbSensors.Location = new System.Drawing.Point(372, 61);
            this.lbSensors.Name = "lbSensors";
            this.lbSensors.Size = new System.Drawing.Size(270, 88);
            this.lbSensors.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(372, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSaveRoomError
            // 
            this.lblSaveRoomError.AutoSize = true;
            this.lblSaveRoomError.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveRoomError.Location = new System.Drawing.Point(18, 146);
            this.lblSaveRoomError.Name = "lblSaveRoomError";
            this.lblSaveRoomError.Size = new System.Drawing.Size(0, 12);
            this.lblSaveRoomError.TabIndex = 18;
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
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(307, 39);
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
            this.comboRoomS.SelectedIndexChanged += new System.EventHandler(this.comboRoomS_SelectedIndexChanged);
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
            this.comboRoomE.SelectedIndexChanged += new System.EventHandler(this.comboRoomE_SelectedIndexChanged);
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
            this.comboRoomW.SelectedIndexChanged += new System.EventHandler(this.comboRoomW_SelectedIndexChanged);
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
            this.comboRoomN.SelectedIndexChanged += new System.EventHandler(this.comboRoomN_SelectedIndexChanged);
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
            this.pnlViewRooms.Controls.Add(this.lblRoomCount);
            this.pnlViewRooms.Controls.Add(this.lblAddRoomError);
            this.pnlViewRooms.Controls.Add(this.groupBox1);
            this.pnlViewRooms.Controls.Add(this.btnAddRoom);
            this.pnlViewRooms.Controls.Add(this.label1);
            this.pnlViewRooms.Controls.Add(this.lblFloor);
            this.pnlViewRooms.Controls.Add(this.comboSelectFloor);
            this.pnlViewRooms.Controls.Add(this.btnViewRoom);
            this.pnlViewRooms.Controls.Add(this.lblRooms);
            this.pnlViewRooms.Controls.Add(this.listboxRooms);
            this.pnlViewRooms.Location = new System.Drawing.Point(19, 61);
            this.pnlViewRooms.Name = "pnlViewRooms";
            this.pnlViewRooms.Size = new System.Drawing.Size(654, 218);
            this.pnlViewRooms.TabIndex = 7;
            // 
            // lblRoomCount
            // 
            this.lblRoomCount.AutoSize = true;
            this.lblRoomCount.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCount.Location = new System.Drawing.Point(72, 8);
            this.lblRoomCount.Name = "lblRoomCount";
            this.lblRoomCount.Size = new System.Drawing.Size(0, 14);
            this.lblRoomCount.TabIndex = 26;
            // 
            // lblAddRoomError
            // 
            this.lblAddRoomError.AutoSize = true;
            this.lblAddRoomError.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoomError.Location = new System.Drawing.Point(439, 191);
            this.lblAddRoomError.Name = "lblAddRoomError";
            this.lblAddRoomError.Size = new System.Drawing.Size(0, 14);
            this.lblAddRoomError.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddFloorError);
            this.groupBox1.Controls.Add(this.btnAddFloor);
            this.groupBox1.Controls.Add(this.comboFloorNum);
            this.groupBox1.Controls.Add(this.comboNoOfRooms);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(442, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Floor";
            // 
            // lblAddFloorError
            // 
            this.lblAddFloorError.AutoSize = true;
            this.lblAddFloorError.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFloorError.Location = new System.Drawing.Point(3, 119);
            this.lblAddFloorError.Name = "lblAddFloorError";
            this.lblAddFloorError.Size = new System.Drawing.Size(0, 14);
            this.lblAddFloorError.TabIndex = 26;
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.Font = new System.Drawing.Font("American Typewriter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFloor.Location = new System.Drawing.Point(6, 77);
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(187, 39);
            this.btnAddFloor.TabIndex = 24;
            this.btnAddFloor.Text = "+";
            this.btnAddFloor.UseVisualStyleBackColor = true;
            this.btnAddFloor.Click += new System.EventHandler(this.btnAddFloor_Click);
            // 
            // comboFloorNum
            // 
            this.comboFloorNum.FormattingEnabled = true;
            this.comboFloorNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboFloorNum.Location = new System.Drawing.Point(118, 23);
            this.comboFloorNum.Name = "comboFloorNum";
            this.comboFloorNum.Size = new System.Drawing.Size(75, 20);
            this.comboFloorNum.TabIndex = 18;
            // 
            // comboNoOfRooms
            // 
            this.comboNoOfRooms.FormattingEnabled = true;
            this.comboNoOfRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboNoOfRooms.Location = new System.Drawing.Point(118, 50);
            this.comboNoOfRooms.Name = "comboNoOfRooms";
            this.comboNoOfRooms.Size = new System.Drawing.Size(75, 20);
            this.comboNoOfRooms.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "Floor number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "No. of Rooms";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("American Typewriter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(233, 166);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(201, 39);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "+";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 12;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(269, 8);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(114, 14);
            this.lblFloor.TabIndex = 19;
            this.lblFloor.Text = "View Floor No.";
            // 
            // comboSelectFloor
            // 
            this.comboSelectFloor.FormattingEnabled = true;
            this.comboSelectFloor.Location = new System.Drawing.Point(389, 5);
            this.comboSelectFloor.Name = "comboSelectFloor";
            this.comboSelectFloor.Size = new System.Drawing.Size(45, 21);
            this.comboSelectFloor.TabIndex = 17;
            this.comboSelectFloor.SelectedIndexChanged += new System.EventHandler(this.comboSelectFloor_SelectedIndexChanged);
            // 
            // btnViewRoom
            // 
            this.btnViewRoom.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoom.Location = new System.Drawing.Point(12, 166);
            this.btnViewRoom.Name = "btnViewRoom";
            this.btnViewRoom.Size = new System.Drawing.Size(215, 39);
            this.btnViewRoom.TabIndex = 15;
            this.btnViewRoom.Text = "View Room";
            this.btnViewRoom.UseVisualStyleBackColor = true;
            this.btnViewRoom.Click += new System.EventHandler(this.btnViewRoom_Click);
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(11, 8);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(55, 14);
            this.lblRooms.TabIndex = 11;
            this.lblRooms.Text = "Rooms";
            // 
            // listboxRooms
            // 
            this.listboxRooms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pDCRoomBindingSource1, "RoomID", true));
            this.listboxRooms.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxRooms.FormattingEnabled = true;
            this.listboxRooms.ItemHeight = 14;
            this.listboxRooms.Location = new System.Drawing.Point(14, 30);
            this.listboxRooms.Name = "listboxRooms";
            this.listboxRooms.Size = new System.Drawing.Size(420, 130);
            this.listboxRooms.TabIndex = 10;
            // 
            // pDCRoomBindingSource1
            // 
            this.pDCRoomBindingSource1.DataMember = "PDC_Room";
            this.pDCRoomBindingSource1.DataSource = this.safeHomeDataSet;
            // 
            // safeHomeDataSet
            // 
            this.safeHomeDataSet.DataSetName = "SafeHomeDataSet";
            this.safeHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnLaunchEmulator.Visible = false;
            this.btnLaunchEmulator.Click += new System.EventHandler(this.btnLaunchEmulator_Click);
            // 
            // pDCSensorBindingSource
            // 
            this.pDCSensorBindingSource.DataMember = "PDC_Sensor";
            this.pDCSensorBindingSource.DataSource = this.safeHomeDataSet;
            // 
            // pDC_SensorTableAdapter
            // 
            this.pDC_SensorTableAdapter.ClearBeforeFill = true;
            // 
            // pDCRoomBindingSource
            // 
            this.pDCRoomBindingSource.DataMember = "PDC_Room";
            this.pDCRoomBindingSource.DataSource = this.safeHomeDataSet;
            // 
            // pDC_RoomTableAdapter
            // 
            this.pDC_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(690, 287);
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
            this.pnlViewRooms.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDCRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCSensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCRoomBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegisterPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.Label lblLoginErr;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.ComboBox comboAddSensor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSensor;
        private System.Windows.Forms.Label lblAddSensor;
        private System.Windows.Forms.Button btnLaunchEmulator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRooms;
        private SafeHomeDataSet safeHomeDataSet;
        private System.Windows.Forms.BindingSource pDCSensorBindingSource;
        private SafeHomeDataSetTableAdapters.PDC_SensorTableAdapter pDC_SensorTableAdapter;
        private System.Windows.Forms.Button btnViewRoom;
        private System.Windows.Forms.Label lblRegisterError;
        private System.Windows.Forms.ListBox listboxRooms;
        private System.Windows.Forms.BindingSource pDCRoomBindingSource;
        private SafeHomeDataSetTableAdapters.PDC_RoomTableAdapter pDC_RoomTableAdapter;
        private System.Windows.Forms.BindingSource pDCRoomBindingSource1;
        private System.Windows.Forms.Label lblSaveRoomError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbSensors;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.ComboBox comboFloorNum;
        private System.Windows.Forms.ComboBox comboSelectFloor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddFloor;
        private System.Windows.Forms.ComboBox comboNoOfRooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAddRoomError;
        private System.Windows.Forms.Label lblAddFloorError;
        private System.Windows.Forms.Label lblRoomCount;
    }
}