namespace Inventory_Program7
{
    partial class Add_Supplies
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
            this.addItemsBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.itemNamelabel = new System.Windows.Forms.Label();
            this.qtyReqLabel = new System.Windows.Forms.Label();
            this.qtyHasLabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.qtyReqTextBox = new System.Windows.Forms.TextBox();
            this.qtyHasTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addItemsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemsBox
            // 
            this.addItemsBox.Controls.Add(this.qtyHasTextBox);
            this.addItemsBox.Controls.Add(this.qtyReqTextBox);
            this.addItemsBox.Controls.Add(this.nameTextBox);
            this.addItemsBox.Controls.Add(this.IDtextBox);
            this.addItemsBox.Controls.Add(this.qtyHasLabel);
            this.addItemsBox.Controls.Add(this.qtyReqLabel);
            this.addItemsBox.Controls.Add(this.itemNamelabel);
            this.addItemsBox.Controls.Add(this.IDlabel);
            this.addItemsBox.Location = new System.Drawing.Point(55, 48);
            this.addItemsBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addItemsBox.Name = "addItemsBox";
            this.addItemsBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addItemsBox.Size = new System.Drawing.Size(745, 298);
            this.addItemsBox.TabIndex = 0;
            this.addItemsBox.TabStop = false;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(32, 39);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(61, 18);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "Item ID";
            // 
            // itemNamelabel
            // 
            this.itemNamelabel.AutoSize = true;
            this.itemNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNamelabel.Location = new System.Drawing.Point(32, 105);
            this.itemNamelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemNamelabel.Name = "itemNamelabel";
            this.itemNamelabel.Size = new System.Drawing.Size(89, 18);
            this.itemNamelabel.TabIndex = 1;
            this.itemNamelabel.Text = "Item Name";
            // 
            // qtyReqLabel
            // 
            this.qtyReqLabel.AutoSize = true;
            this.qtyReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyReqLabel.Location = new System.Drawing.Point(32, 162);
            this.qtyReqLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.qtyReqLabel.Name = "qtyReqLabel";
            this.qtyReqLabel.Size = new System.Drawing.Size(142, 18);
            this.qtyReqLabel.TabIndex = 2;
            this.qtyReqLabel.Text = "Quantity Required";
            // 
            // qtyHasLabel
            // 
            this.qtyHasLabel.AutoSize = true;
            this.qtyHasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyHasLabel.Location = new System.Drawing.Point(30, 226);
            this.qtyHasLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.qtyHasLabel.Name = "qtyHasLabel";
            this.qtyHasLabel.Size = new System.Drawing.Size(135, 18);
            this.qtyHasLabel.TabIndex = 3;
            this.qtyHasLabel.Text = "Quantity on hand";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(313, 36);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(214, 24);
            this.IDtextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(313, 96);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(419, 24);
            this.nameTextBox.TabIndex = 5;
            // 
            // qtyReqTextBox
            // 
            this.qtyReqTextBox.Location = new System.Drawing.Point(313, 159);
            this.qtyReqTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.qtyReqTextBox.Name = "qtyReqTextBox";
            this.qtyReqTextBox.Size = new System.Drawing.Size(139, 24);
            this.qtyReqTextBox.TabIndex = 6;
            // 
            // qtyHasTextBox
            // 
            this.qtyHasTextBox.Location = new System.Drawing.Point(313, 226);
            this.qtyHasTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.qtyHasTextBox.Name = "qtyHasTextBox";
            this.qtyHasTextBox.Size = new System.Drawing.Size(136, 24);
            this.qtyHasTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(525, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 30);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(368, 357);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(103, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Add_Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 399);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addItemsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Add_Supplies";
            this.Text = "Add_Supplies";
            this.addItemsBox.ResumeLayout(false);
            this.addItemsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addItemsBox;
        private System.Windows.Forms.TextBox qtyHasTextBox;
        private System.Windows.Forms.TextBox qtyReqTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label qtyHasLabel;
        private System.Windows.Forms.Label qtyReqLabel;
        private System.Windows.Forms.Label itemNamelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}