/******************************************************************************
 * Name: Rephael Edwards
 * Course: CMPS4143
 * Instructor Dr. C. Stringfellow
 * Program Description: This program demonstrates the use of MDI's as well as
 *                      menus, listboxes and a user control to input and output
 *                      to files.
 *****************************************************************************/
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
using System.Collections;


namespace Inventory_Program7
{
    public partial class ClinicInventory : Form
    {
        OpenFileDialog openFile1 = new OpenFileDialog();
        // string to store the name of the file that was opened 
        string file;

        //Requires: nothing
        //Purpose: Constructor to create the form
        //Returns: nothing
        public ClinicInventory()
        {
          InitializeComponent();
          //menuStrip.Enabled = false;
          // the event handler connected to the login form 
          login.ButtonClick += new EventHandler(loginControl_Load);
        }// end of constructor

        //Requires: An arguement from the user control submit.
        //Purpose: To enable the toolstrip.
        //Returns: nothing
        protected void loginControl_Load(object sender, EventArgs e)
        {
            // enable the toolstrip
            menuStrip.Enabled = true;    
        }
        //---------------------------------------------------------------------
        //Requires: User click on new menu item
        //Purpose: To allow creation of a new Clinic inventory.
        //Returns: nothing
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Clinic childForm = new Clinic();
            childForm.MdiParent = this;
            // Test result
            SaveFileDialog newFile = new SaveFileDialog();
            newFile.ShowDialog();
            string newFileName = newFile.FileName;

            if (newFileName != "")
            {
                FileStream output = new FileStream(newFileName,
                        FileMode.OpenOrCreate, FileAccess.ReadWrite);
                childForm.ChildFileName = newFileName;
                Clinic activeChild = this.ActiveMdiChild as Clinic;
                activeChild.Text = newFileName;
                output.Close();
                MessageBox.Show("Open the file to enter information");
            }  
        }// end of new tool strip menu item
        //---------------------------------------------------------------------

        //Requires: A click on the open menu item
        //Purpose: to open a file
        //Returns: nothing
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clinic childForm = new Clinic();
            childForm.MdiParent = this;
            // Test result
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                //open the file and let the active form
                // read the information from the file
                file = openFile1.SafeFileName;
                try
                {
                    childForm.Practice = file;
                    childForm.ChildFileName = file;
                    childForm.ReadInformation(file);
                    childForm.Show();
                }
                catch (IOException)
                {
                    MessageBox.Show("File Error", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }// end of open tool strip menu item

        //---------------------------------------------------------------------

        //Requires: User click on insert in menu.
        //Purpose: To enable inserting a record into a file.
        //Returns: nothing
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clinic activeChild = this.ActiveMdiChild as Clinic;

            if (activeChild != null)
            {
                insertData(activeChild);
            }
            else
                MessageBox.Show("Open a file for inserting data");


        }// end of insert tool strip menu item

        //---------------------------------------------------------------------

        //Requires: User click on about in menu.
        //Purpose: To give information about the program.
        //Returns: nothing
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This program uses MDI's to keep track of inventories."
                + "\n It allows the user to add stock to inventories, \n " +
                " edit existing stock and create new inventories." +
                "\n\n Creator: Rephael Edwards");
        }// end of about tool strip menu item

        //---------------------------------------------------------------------

        //Requires: User click on save in menu.
        //Purpose: To save records.
        //Returns: nothing
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileForSaving;

            // for each child form that is open
            foreach (Clinic subForm in this.MdiChildren)
            {
                // SaveFileDialog fileSave = new SaveFileDialog();
                // object for serializing Record in binary format
                BinaryFormatter writer = new BinaryFormatter();
                FileStream stream;

                fileForSaving = subForm.ChildFileName;
                //fileForSaving = Path.GetFileName(pathName);
                stream = new FileStream(fileForSaving, FileMode.OpenOrCreate,
                            FileAccess.Write);
                // for each record in the child form, save it to the file
                foreach (Record item in subForm.RecordList)
                {
                    writer.Serialize(stream, item);
                }
                stream.Close();

            }
        }// end of save tool strip menu item

        //---------------------------------------------------------------------

        //Requires: User click on update in menu.
        //Purpose: To change information for a record.
        //Returns: nothing
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on a record to select first.");
            // open an instance of the insert form
            Clinic activeChild = this.ActiveMdiChild as Clinic;

            if (activeChild != null)
            {
                //create the form for information to be added then show it
                Add_Supplies addingForm = new Add_Supplies();
                addingForm.ShowDialog();

                Record newItem = new Record(addingForm.ID, addingForm.ItemName, "",
                     addingForm.QtyReq, addingForm.Quantity);
                activeChild.UpdateRecord(newItem);

                if (addingForm.DialogResult != DialogResult.OK)
                { addingForm.Close(); }
            }
            else
                MessageBox.Show("Inactive Child Form");

        }// end of update toolstrip menu item

        //---------------------------------------------------------------------

        //Requires: User click on delete in menu.
        //Purpose: To delete a record.
        //Returns: nothing
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a record");
            Clinic activeChild = this.ActiveMdiChild as Clinic;

            if (activeChild != null)
            {
                activeChild.DeleteRecord();
            }
            else
                MessageBox.Show("Inactive Child Form");

        }// end of delete tool strip menu item

        //---------------------------------------------------------------------

        //Requires: User click on exit in menu.
        //Purpose: To exit the program.
        //Returns: nothing
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }// end of exit tool strip menu item

        //---------------------------------------------------------------------

        //Requires: An active child for insertion
        //Purpose: To insert the information given by the user into a record.
        //Returns: nothing
        private void insertData(Clinic activeChild)
        {

            //create the form for information to be added then show it
            Add_Supplies addingForm = new Add_Supplies();
            addingForm.ShowDialog();
            Record newItem = new Record(addingForm.ID, addingForm.ItemName, "",
              addingForm.QtyReq, addingForm.Quantity);
            activeChild.InsertRecord(newItem);

            if (addingForm.DialogResult == DialogResult.OK)
            {
                addingForm.Close();
            }
        }// end of insertData function
        //---------------------------------------------------------------------
    }
}

