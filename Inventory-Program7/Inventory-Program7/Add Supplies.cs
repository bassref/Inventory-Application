/******************************************************************************
 * Name: Rephael Edwards
 * File: Add_Supplies.cs
 * Purpose: The form for inserting or updating records 
 * ***************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Inventory_Program7
{
    public partial class Add_Supplies : Form
    {
        public int ID, Quantity;
        public double QtyReq;
        public string ItemName, Practice;

        //Requires: nothing
        //Purpose: Constructor
        //Returns: nothing
        public Add_Supplies()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------

        //Requires:User click on the ok button 
        //Purpose: To save the information entered.
        //Returns: nothing
        private void okButton_Click(object sender, EventArgs e)
        {
           
            // store the information from the text boxes in a new record            
            ID = int.Parse(IDtextBox.Text);
            ItemName = nameTextBox.Text;
            Practice = "";
            QtyReq = double.Parse(qtyReqTextBox.Text);
            Quantity = int.Parse(qtyHasTextBox.Text);

            this.Close();
        }
        //---------------------------------------------------------------------

        //Requires: User click on cancel.
        //Purpose: To close the form being used.
        //Returns: nothing
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
