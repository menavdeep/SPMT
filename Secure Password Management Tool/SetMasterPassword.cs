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
    public partial class SetMasterPassword : Form
    {
        public SetMasterPassword()
        {
            InitializeComponent();
        }

        private void BtnSaveMasterPassword_Click(object sender, EventArgs e)
        {
            string masterPassword = txtMasterPassword.Text;
            string confirmMasterPassword = txtConfirmMasterPassword.Text;

            if (masterPassword == confirmMasterPassword)
            {
                string filePath = @"C:\Users\Navdeep Singh\source\repos\SPMT\Secure Password Management Tool\Database\Database.txt";
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {

                }
                
                File.WriteAllText(filePath, txtMasterPassword.Text);
                
                MessageBox.Show("New Master Password created.");

            }
            else
            {
                MessageBox.Show("Passwords do not match, please try again.");
            }
        }
    }
}
