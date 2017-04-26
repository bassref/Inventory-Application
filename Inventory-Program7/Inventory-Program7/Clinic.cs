/******************************************************************************
 * Name: Rephael Edwards
 * File: Clinic.cs
 * Purpose: The child form. To carry out any functions associated with an  
 *          instance of the child form.
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
using System.Collections;


namespace Inventory_Program7
{
    public partial class Clinic : Form
    {
        // name of the filename
        private string childFileName;
        // record array to store the records read in
        ArrayList recordList = new ArrayList();

        //Requires: nothing
        //Purpose: Constructor to create the form
        //Returns: nothing
        public Clinic()
        {
            InitializeComponent();           
        }// end of constructor

        
        public void CreateNewInventory()
        {
            
        }
        //Requires: The input file selected by the user
        //Purpose: To process the information from the input file
        //Returns: nothing
        public  void ReadInformation(string file)
        {
            int recordCount = 0;
            FileStream stream;
            stream = new FileStream(file, FileMode.Open,
                                    FileAccess.Read);
            BinaryFormatter reader = new BinaryFormatter();
            childFileName = file;
            stream.Position = 0;
            try
            { 
                // for each reacord in the input form, read in the record,
                //store it in the list box and add it to the array of records.
               while(stream.Length != stream.Position)
                {
                    // get the next record in the file
                    Record record = (Record)reader.Deserialize(stream);
                    string output = record.ID + "\t" + record.ItemName + 
                        "\t\t\t" + record.QtyReq + "\t\t" + record.Quantity;
                    ClinicData.Items.Add(output);
                   // place the name of the practice in the label on the form
                    this.Text = file;
                    recordList.Add(record);
                    recordCount += 1;
                }
               clinicName.Text += "This practice contains " + recordCount + " item(s)";
            }
           catch (Exception ex)
            {
                MessageBox.Show("Error reading file from disk." + ex.Message);
            }

            stream.Close();
        }// end ReadInformation function

        //Requires: The field data for a record to be inserted.
        //Purpose: To insert a record into the listbox and reccord array.
        //Returns: Nothing
        public void InsertRecord(Record record)
        {
            string data = record.ToString();
            ClinicData.Items.Add(data);
            recordList.Add(record);
        }// end InsertRecord function

        //Requires: A record needs to be selected.
        //Purpose: To update the data for the record.
        //Returns: Nothing
        public void UpdateRecord(Record record)
        {           
            int position = 0;
            string data;

            // click on the item to be changed
            position  = ClinicData.SelectedIndex;
            //remove the item selected
            ClinicData.Items.RemoveAt(position);
            //change the items sent in to a string
            data = record.ToString();
            // update the items in that position
            ClinicData.Items.Add(record);
            int theLength = ClinicData.Items.IndexOf(record);
            //update the record in the recordList array
            recordList[position] = record;

        }// end update  record function

        //Requires: A record needs to be selected.
        //Purpose: To delete a record.
        //Returns: Nothing
        public void DeleteRecord()
        {
            // click om the item to be changed
            int position = ClinicData.SelectedIndex;
            // remove the item
            ClinicData.Items.RemoveAt(position);
            //update the record in the recordList array
            recordList.RemoveAt(position);

        }// end delete  record function

        //Requires: Nothing
        //Purpose: To store records.
        //Returns: The recordList array list.
        public ArrayList RecordList
        {
            get
            {
                return recordList;
            }
            set
            {
                recordList = value;
            }
        } // end recordList property

        //Requires: Nothing
        //Purpose: To store the name of the child form when 
        //          it is selected to be opened.
        //Returns: the name of the file of the child form.
        public string ChildFileName
        {
            get
            {
                return childFileName;
            }
            set
            {
                childFileName = value;
            }
        } // end recordList property

        public string Practice { get; set; }
    }
}
