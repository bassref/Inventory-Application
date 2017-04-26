/******************************************************************************
 * Name: Rephael Edwards
 * File: Record.cs
 * Purpose: The record class.
 * ***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Program7
{
    [Serializable]
    public class Record
    {
        int id, quantity;
        string name, practice;
        double qtyReq;

        // default constructor
        public Record() : this (0, "", "", 0, 0)
        {

        }

        //parameterized constructor
        public Record(int id, string name, string practice,
            double qtyReq, int quantity)
        {
            ID = id;
            ItemName = name;
            Practice = practice;
            QtyReq = qtyReq;
            Quantity = quantity;

        }// end parameterized constructor

        //Requires: nothing
        //Purpose: To convert information from a record to a string
        //Returns: a string
        public override string ToString()
        {
            string recordInfo = id + "\t" + name + "\t\t\t" + qtyReq + "\t\t" + quantity;
            return  recordInfo;
        }// end of ToString override

        //Requires: nothing
        //Purpose: To get and set the ID value
        //Returns: the value for ID
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        } // end property ID

        //Requires: nothing
        //Purpose: To get and set the Item name value
        //Returns: the value for  Item name
        public string ItemName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }// end property Name

        //Requires: nothing
        //Purpose: To get and set the value for quantity of the item required
        //Returns: the value for the quantity of the item required
        public double QtyReq
        {
            get
            {
                return qtyReq;
            }
            set
            {
                qtyReq = (int) value;
            }
        }// end property QtyReq

        //Requires: nothing
        //Purpose: To get and set the value for quantity of the item in stock
        //Returns: the value for the quantity of the item in stock
        public int Quantity 
        { 
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        // end property Quantity

        //Requires: nothing
        //Purpose: To get and set the value the name of the practice
        //Returns: the value for the name of the practice
        public string Practice
        { 
            get
            {
                return practice;
            }
            set
            {
                practice = value;
            }
        }// end property Practice
    }
}
