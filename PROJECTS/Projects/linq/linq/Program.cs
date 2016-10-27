using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data;

namespace linq
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            DataContext d = new DataContext("Data Source = 172.17.2.13; Initial Catalog = M1037727; Integrated Security = True");
            //var linq = from emp in d.employee where emp.emp_name = "keerthi" select emp;
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
