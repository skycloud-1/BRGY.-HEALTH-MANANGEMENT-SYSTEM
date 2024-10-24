using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRGY.HEALTH_MANAGEMENT_SYSTEM_WINDOWSAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //LogIN here
        }
    }
}
