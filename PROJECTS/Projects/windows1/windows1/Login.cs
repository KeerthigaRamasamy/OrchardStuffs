using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pwd = textBox2.Text;
        }
        private void validate_email(string email)
        {
            //textBox1.BackColor = "#FF000";

        }
        private void validate_pwd(string pwd)
        {

        }
    }
}
