using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonsTracker
{
    public partial class frmPassword : Form
    {

        public string strPassword;
        
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            strPassword = txtPassword.Text;
            this.Close();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            this.txtPassword.Focus();
        }
    }
}