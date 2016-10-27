using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (var d = new M1037727Entities()) //object of the data context
            {
                int id = Convert.ToInt32(textBox1.Text);
                string first = textBox2.Text;
                string last = textBox3.Text;
                int age = Convert.ToInt32(textBox4.Text);

                //creating object of the class detail(table)
                detail obj = new detail();
                obj.emp_id = id;
                obj.age = age;
                obj.first_name = first;
                obj.last_name = last;
                //inserting 
                d.details.Add(obj);
                d.SaveChanges();    
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
