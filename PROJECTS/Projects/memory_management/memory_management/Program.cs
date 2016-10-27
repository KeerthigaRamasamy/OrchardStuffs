using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace memory_management
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a1, b1;
            string s1, s2;
            Console.WriteLine("-----Memory Management-----");
            //connection string
            string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";
            a obj = new a();
            Console.WriteLine("-----Addition-----");
            Console.WriteLine("Enter two numbers for addition");
            while (!(int.TryParse(Console.ReadLine(), out a1)))
                Console.WriteLine("Invalid entry, enter again");
            while (!(int.TryParse(Console.ReadLine(), out b1)))
                Console.WriteLine("Invalid entry, enter again");
            //calling add function
            obj.add(a1,b1);
            //calling sql function
            Console.WriteLine("Sql operations");
            Console.WriteLine("Enter the employee name and designation to be inserted into the employee table");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            obj.sql_operation(str,s1,s2);
            obj.Dispose();
           // GC.Collect();
            Console.ReadKey();
        }
    }


    //class inherited From idisposable interface to implememt dispose method
    class a:IDisposable
    {
        SqlConnection conn;
         public bool disposed = false;
        //constructor
        
        public void add(int var1, int var2)
        {
            Console.WriteLine("The sum of " + " " + var1 + " " + "and" + " " + var2 + " " + "is" + " " + (var1 + var2));
        }
        public void sql_operation(string str,string s1,string s2)
        {
            using (conn = new SqlConnection(str))
                {
                conn = new SqlConnection(str);
                conn.Open();
                Console.WriteLine("Sql command for insertion got executed");
                SqlCommand com = new SqlCommand("INSERT INTO employee(emp_name,designation)VALUES('"+s1+"','"+s2+"');", conn);
                int s = com.ExecuteNonQuery();
                Console.WriteLine("Rows affected after executing the sql command" + s);
            }
        }

        //implementation of dispose method
        public void Dispose()
        {
            Dispose(true);
            Console.WriteLine("dispose method called");

            //supressing the finalize method
            GC.SuppressFinalize(this);
        }

        //disposed parameter is to check if it is called from dispose or finalize method
        protected virtual void Dispose(bool disposing)               //overload function
        {
            if (disposed)
                return;
            if(disposing) //call from dispose method
            {
                //clean managed resources     
            }
            conn.Close();
            //clean unmanaged resources
            disposed = true;
        }

        //desctructor
        ~a()
        {
            Console.WriteLine("finalize method called");
            //if the user fails to call the dispose method, finalize method calls it
        }
        
    }
 
}
