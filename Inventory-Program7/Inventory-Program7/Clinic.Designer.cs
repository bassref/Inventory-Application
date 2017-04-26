namespace Inventory_Program7
{
    partial class Clinic
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
            this.ClinicData = new System.Windows.Forms.ListBox();
            this.clinicName = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.qtyReqLabel = new System.Windows.Forms.Label();
            this.qtyHaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClinicData
            // 
            this.ClinicData.FormattingEnabled = true;
            this.ClinicData.Location = new System.Drawing.Point(38, 68);
            this.ClinicData.Name = "ClinicData";
            this.ClinicData.Size = new System.Drawing.Size(429, 186);
            this.ClinicData.TabIndex = 0;
            // 
            // clinicName
            // 
            this.clinicName.AutoSize = true;
            this.clinicName.Location = new System.Drawing.Point(141, 24);
            this.clinicName.Name = "clinicName";
            this.clinicName.Size = new System.Drawing.Size(0, 13);
            this.clinicName.TabIndex = 2;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(49, 51);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(121, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // qtyReqLabel
            // 
            this.qtyReqLabel.AutoSize = true;
            this.qtyReqLabel.Location = new System.Drawing.Point(241, 51);
            this.qtyReqLabel.Name = "qtyReqLabel";
            this.qtyReqLabel.Size = new System.Drawing.Size(92, 13);
            this.qtyReqLabel.TabIndex = 5;
            this.qtyReqLabel.Text = "Quantity Required";
            // 
            // qtyHaveLabel
            // 
            this.qtyHaveLabel.AutoSize = true;
            this.qtyHaveLabel.Location = new System.Drawing.Point(377, 51);
            this.qtyHaveLabel.Name = "qtyHaveLabel";
            this.qtyHaveLabel.Size = new System.Drawing.Size(46, 13);
            this.qtyHaveLabel.TabIndex = 6;
            this.qtyHaveLabel.Text = "Quantity";
            // 
            // Clinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 266);
            this.Controls.Add(this.qtyHaveLabel);
            this.Controls.Add(this.qtyReqLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.clinicName);
            this.Controls.Add(this.ClinicData);
            this.Name = "Clinic";
            this.Text = "Clinic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClinicData;
        private System.Windows.Forms.Label clinicName;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label qtyReqLabel;
        private System.Windows.Forms.Label qtyHaveLabel;
    }
}