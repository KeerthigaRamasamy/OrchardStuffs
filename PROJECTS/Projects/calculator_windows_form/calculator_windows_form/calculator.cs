using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_windows_form
{
    public partial class calculator : Form
    {
        public int a, b,c;
        public calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                errorProvider1.SetError(textBox1, "Enter a value");
            }
            else if (!(int.TryParse(textBox1.Text, out a)))
            {
                errorProvider1.SetError(textBox1, "Enter only valid integer");
                textBox1.Text = null;
            }
           
            if (textBox2.Text == null)
            {
                errorProvider2.SetError(textBox2, "Enter a value");
            }
            else if (!(int.TryParse(textBox2.Text, out b)))
            {
                errorProvider2.SetError(textBox2, "Enter only valid integer");
                textBox2.Text = null;
            }
            else
            {
                c = a * b;
                textBox3.Text = c.ToString();
            }

            //c = a*b;
            //textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!(int.TryParse(textBox1.Text, out a)))
            {
                errorProvider1.SetError(textBox1, "Enter only valid integer");
                textBox1.Text = null;
            }
            else if(textBox1.Text==null)
            {
                errorProvider1.SetError(textBox1, "Enter a value");
            }
            if (!(int.TryParse(textBox2.Text, out b)))
            {
                errorProvider2.SetError(textBox2, "Enter only valid integer");
                textBox2.Text = null;
            }
            else if (textBox2.Text == null)
            {
                errorProvider2.SetError(textBox2, "Enter a value");
            }
            else
            {
                try
                {
                    c = a / b;
                    textBox3.Text = c.ToString();
                }
                catch (DivideByZeroException)
                {
                    errorProvider2.SetError(textBox2, "Divide by zero exception");
                    textBox2.Text = null;
                }
            }      
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(!(int.TryParse(textBox1.Text,out a)))
            {
                errorProvider1.SetError(textBox1, "Enter only valid integer");
                textBox1.Text = null;
            }
            else if (textBox1.Text == null)
            {
                errorProvider1.SetError(textBox1, "Enter a value");
            }
            if (!(int.TryParse(textBox2.Text, out b)))
            {
                errorProvider2.SetError(textBox2, "Enter only valid integer");
                textBox2.Text = null;
            }
            else if (textBox2.Text == null)
            {
                errorProvider2.SetError(textBox2, "Enter a value");
            }
            else
            {
                c = a + b;
                textBox3.Text = c.ToString();
            }
        }
    }
}
