using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonsTracker
{
    public partial class CloseProcedure : System.Windows.Forms.Form
    {
        CommonsDB theData;
        public CloseProcedure()
        {
            InitializeComponent();
        }

        private void CloseProcedure_Load(object sender, EventArgs e)
        {
            theData = new CommonsDB();
            checkClientHelp();
            this.TopMost = true;
           
        }

        private void checkClientHelp()
        {
            
            Hashtable ClosingItems;
            ClosingItems = new Hashtable();
            ClosingItems = theData.readClosingProcedures();
            IDictionaryEnumerator en = ClosingItems.GetEnumerator();
            while (en.MoveNext())
            {
                clbClosing.Items.Add(en.Value.ToString());
                

            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //checks to see if everything has been checked if not it will
            //tell the user and return to the normal state without entering the data
            //back in the DB
            int checkedcount = clbClosing.CheckedItems.Count;
            int itemcount = clbClosing.Items.Count;

            if (checkedcount == itemcount)
            {
                if (txtStaff.Text.Length != 0)
                {
                    theData.WriteCommonsClosing(txtStaff.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("You must enter your name", "Error Msg");
                }
            }
            else
            {
                MessageBox.Show("You must check all items in the list", "Error Msg");
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}