using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimpiesWinForm
{
    public partial class Form1 : Form
    {
        
        // This is the global login name and password.
        private static string VERKOOPNAME = "Verkoop";
        private static string VERKOOPPASSWORD = "Gimpies_Verkoop";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == VERKOOPNAME && password.Text == VERKOOPPASSWORD)
            {
                // var verkoopform = VerkoopForm.ActiveForm;
                var f = new VerkoopForm();
                f.
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}