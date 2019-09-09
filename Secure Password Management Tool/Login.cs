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

namespace Secure_Password_Management_Tool
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Navdeep Singh\source\repos\SPMT\Secure Password Management Tool\Database\Database.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                //Read database
            }
            else
            {

                MessageBox.Show("Master Password is not setup, please create a Master Password.");
            }
        }

        private void BtnSetMasterPassword_Click(object sender, EventArgs e)
        {
            SetMasterPassword frm = new SetMasterPassword();
            frm.Show();
        }
    }
}
