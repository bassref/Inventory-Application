/******************************************************************************
 * Name: Rephael Edwards
 * File: Login.cs
 * Purpose: The control for logging in.
 * ***************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Program7
{
    public partial class Login : UserControl
    {
        public event EventHandler ButtonClick;

        //Requires: nothing
        //Purpose: Constructor to create the form
        //Returns: nothing
        public Login()
        {
            InitializeComponent();
        }

        //Requires: The submit button to be clicked.
        //Purpose: To activate an event.
        //Returns: nothing
        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, e);
                // clear the password textbox
                pwordTextBox.Clear();
            }
                
        }
    }
}
