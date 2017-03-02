namespace SafeHome
{
    partial class SensorEmulator
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.lblSensorEmulator = new System.Windows.Forms.Label();
            this.comboSensor = new System.Windows.Forms.ComboBox();
            this.safeHomeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDCSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFloor = new System.Windows.Forms.ComboBox();
            this.lblSubmit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.safeHomeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCSensorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(262, 41);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboRoom
            // 
            this.comboRoom.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(63, 82);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(210, 24);
            this.comboRoom.TabIndex = 14;
            this.comboRoom.SelectedIndexChanged += new System.EventHandler(this.comboRoom_SelectedIndexChanged);
            // 
            // lblSensorEmulator
            // 
            this.lblSensorEmulator.AutoSize = true;
            this.lblSensorEmulator.Font = new System.Drawing.Font("American Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorEmulator.Location = new System.Drawing.Point(56, 14);
            this.lblSensorEmulator.Name = "lblSensorEmulator";
            this.lblSensorEmulator.Size = new System.Drawing.Size(178, 25);
            this.lblSensorEmulator.TabIndex = 13;
            this.lblSensorEmulator.Text = "Sensor Emulator";
            // 
            // comboSensor
            // 
            this.comboSensor.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSensor.FormattingEnabled = true;
            this.comboSensor.Location = new System.Drawing.Point(63, 113);
            this.comboSensor.Name = "comboSensor";
            this.comboSensor.Size = new System.Drawing.Size(210, 24);
            this.comboSensor.TabIndex = 12;
            this.comboSensor.SelectedIndexChanged += new System.EventHandler(this.comboSensor_SelectedIndexChanged);
            // 
            // pDCSensorBindingSource
            // 
            this.pDCSensorBindingSource.DataMember = "PDC_Sensor";
            this.pDCSensorBindingSource.DataSource = this.safeHomeDataSetBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Detail";
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(63, 143);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(211, 24);
            this.txtDetail.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Floor";
            // 
            // comboFloor
            // 
            this.comboFloor.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFloor.FormattingEnabled = true;
            this.comboFloor.Location = new System.Drawing.Point(63, 51);
            this.comboFloor.Name = "comboFloor";
            this.comboFloor.Size = new System.Drawing.Size(210, 24);
            this.comboFloor.TabIndex = 15;
            this.comboFloor.SelectedIndexChanged += new System.EventHandler(this.comboFloor_SelectedIndexChanged);
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.Location = new System.Drawing.Point(12, 231);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(0, 12);
            this.lblSubmit.TabIndex = 22;
            // 
            // SensorEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.lblSensorEmulator);
            this.Controls.Add(this.comboSensor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFloor);
            this.Name = "SensorEmulator";
            this.Text = "SensorEmulator";
            ((System.ComponentModel.ISupportInitialize)(this.safeHomeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label lblSensorEmulator;
        private System.Windows.Forms.ComboBox comboSensor;
        private System.Windows.Forms.BindingSource safeHomeDataSetBindingSource;
        private System.Windows.Forms.BindingSource pDCSensorBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFloor;
        private System.Windows.Forms.Label lblSubmit;
    }
}