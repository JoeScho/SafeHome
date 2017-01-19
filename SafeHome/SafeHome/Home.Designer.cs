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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnViewRooms = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlViewRooms = new System.Windows.Forms.Panel();
            this.pnlAddRoom = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSafeHome
            // 
            this.lblSafeHome.AutoSize = true;
            this.lblSafeHome.Font = new System.Drawing.Font("American Typewriter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafeHome.Location = new System.Drawing.Point(12, 9);
            this.lblSafeHome.Name = "lblSafeHome";
            this.lblSafeHome.Size = new System.Drawing.Size(247, 37);
            this.lblSafeHome.TabIndex = 0;
            this.lblSafeHome.Text = "SafeHome v0.1";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnViewRooms
            // 
            this.btnViewRooms.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRooms.Location = new System.Drawing.Point(12, 127);
            this.btnViewRooms.Name = "btnViewRooms";
            this.btnViewRooms.Size = new System.Drawing.Size(108, 39);
            this.btnViewRooms.TabIndex = 3;
            this.btnViewRooms.Text = "View rooms";
            this.btnViewRooms.UseVisualStyleBackColor = true;
            this.btnViewRooms.Click += new System.EventHandler(this.btnViewRooms_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("American Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 310);
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
            this.pnlLogin.Location = new System.Drawing.Point(132, 61);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(540, 288);
            this.pnlLogin.TabIndex = 6;
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.linkLabel1);
            this.gbRegister.Controls.Add(this.button3);
            this.gbRegister.Controls.Add(this.label4);
            this.gbRegister.Controls.Add(this.textBox3);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Controls.Add(this.textBox1);
            this.gbRegister.Controls.Add(this.label3);
            this.gbRegister.Controls.Add(this.textBox2);
            this.gbRegister.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegister.Location = new System.Drawing.Point(264, 3);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(273, 262);
            this.gbRegister.TabIndex = 5;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("American Typewriter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(40, 185);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(189, 14);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View our terms and conditions.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "Password";
            this.textBox3.Location = new System.Drawing.Point(7, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(260, 26);
            this.textBox3.TabIndex = 9;
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
            this.textBox1.Size = new System.Drawing.Size(260, 26);
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
            this.textBox2.Size = new System.Drawing.Size(260, 26);
            this.textBox2.TabIndex = 5;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnSignIn);
            this.gbLogin.Controls.Add(this.lblLoginPwd);
            this.gbLogin.Controls.Add(this.lblLoginUsername);
            this.gbLogin.Controls.Add(this.txtLoginPwd);
            this.gbLogin.Controls.Add(this.txtLoginName);
            this.gbLogin.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(13, 4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(245, 181);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Log in";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(73, 132);
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
            this.txtLoginPwd.Size = new System.Drawing.Size(233, 26);
            this.txtLoginPwd.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.AccessibleName = "Username";
            this.txtLoginName.Location = new System.Drawing.Point(6, 45);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(233, 26);
            this.txtLoginName.TabIndex = 0;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.label1);
            this.pnlHome.Location = new System.Drawing.Point(132, 61);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(540, 288);
            this.pnlHome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "homepage";
            // 
            // pnlViewRooms
            // 
            this.pnlViewRooms.Location = new System.Drawing.Point(132, 61);
            this.pnlViewRooms.Name = "pnlViewRooms";
            this.pnlViewRooms.Size = new System.Drawing.Size(540, 288);
            this.pnlViewRooms.TabIndex = 7;
            // 
            // pnlAddRoom
            // 
            this.pnlAddRoom.Location = new System.Drawing.Point(132, 61);
            this.pnlAddRoom.Name = "pnlAddRoom";
            this.pnlAddRoom.Size = new System.Drawing.Size(540, 288);
            this.pnlAddRoom.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pnlAddRoom);
            this.Controls.Add(this.pnlViewRooms);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewRooms);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSafeHome);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "SafeHome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlLogin.ResumeLayout(false);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSafeHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnViewRooms;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlViewRooms;
        private System.Windows.Forms.Panel pnlAddRoom;
    }
}