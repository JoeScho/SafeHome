namespace SensorEmulator
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
            this.comboSensor = new System.Windows.Forms.ComboBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblSensorEmulator = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSensor
            // 
            this.comboSensor.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSensor.FormattingEnabled = true;
            this.comboSensor.Location = new System.Drawing.Point(13, 60);
            this.comboSensor.Name = "comboSensor";
            this.comboSensor.Size = new System.Drawing.Size(259, 24);
            this.comboSensor.TabIndex = 0;
            this.comboSensor.Text = "Select a sensor";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(13, 90);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(259, 23);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblSensorEmulator
            // 
            this.lblSensorEmulator.AutoSize = true;
            this.lblSensorEmulator.Font = new System.Drawing.Font("American Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorEmulator.Location = new System.Drawing.Point(54, 9);
            this.lblSensorEmulator.Name = "lblSensorEmulator";
            this.lblSensorEmulator.Size = new System.Drawing.Size(178, 25);
            this.lblSensorEmulator.TabIndex = 2;
            this.lblSensorEmulator.Text = "Sensor Emulator";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(59, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(173, 12);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Select a sensor to emulate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSensorEmulator);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.comboSensor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSensor;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lblSensorEmulator;
        private System.Windows.Forms.Label lblDescription;
    }
}

