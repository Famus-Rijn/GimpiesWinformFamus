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
        private static string LOGINNAME = "Verkoop";
        private static string LOGINPASSWORD = "Gimpies_Verkoop";
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == LOGINNAME && password.Text == LOGINPASSWORD)
            {
                
            }
        }
    }
}