using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoring_system_Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Username = "U123";
            string password = "Password123";
            if (txt_Username.Text == Username && txt_Password.Text == password)
            {
                MessageBox.Show("Login successful");
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else MessageBox.Show("Please enter valid Username and password");
        }
    }
}
