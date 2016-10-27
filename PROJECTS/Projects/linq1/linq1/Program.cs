using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

/* basic with linq queries*/
namespace linq1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //DataContext d = new DataContext("Data Source = 172.17.2.13; Initial Catalog = M1037727; Integrated Security = True");
            DataClasses1DataContext d = new DataClasses1DataContext("Data Source = 172.17.2.13; Initial Catalog = M1037727; Integrated Security = True");
            //var c = from emp in d.employees
            //        where emp.emp_name = "keerthi"     //linq query
            //        select emp;
            Class1 obj=new Class1();
            Console.WriteLine("Enter the emp_id to insert into");
            obj.emp_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the emp name to insert into");
            obj.name = Console.ReadLine();
            Console.WriteLine("Enter the emp designation to insert into");
            obj.designation = Console.ReadLine();
            d.employees.InsertOnSubmit(obj);
            d.SubmitChanges();    
        }
    }
}
