namespace SafeHome
{
    partial class Visualisation
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
            this.comboFloors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoRooms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboFloors
            // 
            this.comboFloors.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFloors.FormattingEnabled = true;
            this.comboFloors.Location = new System.Drawing.Point(158, 16);
            this.comboFloors.Name = "comboFloors";
            this.comboFloors.Size = new System.Drawing.Size(40, 25);
            this.comboFloors.TabIndex = 1;
            this.comboFloors.SelectedIndexChanged += new System.EventHandler(this.comboFloors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a floor";
            // 
            // lblNoRooms
            // 
            this.lblNoRooms.AutoSize = true;
            this.lblNoRooms.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRooms.Location = new System.Drawing.Point(204, 19);
            this.lblNoRooms.Name = "lblNoRooms";
            this.lblNoRooms.Size = new System.Drawing.Size(0, 17);
            this.lblNoRooms.TabIndex = 3;
            // 
            // Visualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblNoRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFloors);
            this.Name = "Visualisation";
            this.Text = "Visualisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboFloors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoRooms;
    }
}