using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace disconnected1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");      //connection object
            SqlDataAdapter a = new SqlDataAdapter("SELECT* FROM details ", c);      //data adapter
            DataSet s = new DataSet();

            //fill method implicitly opens and closes the connection
            a.Fill(s, "Details");

            DataTable t = new DataTable();
            t = s.Tables["Details"];                    //populating the data table from data set
            Console.WriteLine("The employee details table");
            Console.WriteLine("Emp_id" + "\t" + "F_name" + "\t" + "l_name" + "\t" + "Age");
            Console.WriteLine();

            //printing the rows in the data table
            foreach (DataRow r in t.Rows)
            {
                Console.Write(r["emp_id"].ToString() + "\t");
                Console.Write(r["first_name"].ToString() + "\t");
                Console.Write(r["last_name"].ToString() + "\t");
                Console.Write(r["age"].ToString() + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
