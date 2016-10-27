using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface
namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
                string name;
                int id;
                decimal a, b, c;
                Console.WriteLine("Enter the employee name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the employee id");
                while (!(int.TryParse(Console.ReadLine(),out id)))
                {
                    Console.WriteLine("Enter a valid integer value");
                }
                 Console.WriteLine("Enter the basepay of the employee");
                 while (!(decimal.TryParse(Console.ReadLine(), out a)))
                {
                    Console.WriteLine("Enter a valid decimal value");
                }
                Console.WriteLine("Enter the hrapay of the employee");
                while (!(decimal.TryParse(Console.ReadLine(), out b)))
                {
                    Console.WriteLine("Enter a valid decimal value");
                }
                Console.WriteLine("Enter the dapay of the employee");
                while (!(decimal.TryParse(Console.ReadLine(), out c)))
                {
                    Console.WriteLine("Enter a valid decimal value");
                }
                salary_details obj1 = new salary_details(name,id,a,b,c);
                obj1.total_salary();
                obj1.display_details();
                Console.ReadKey();
        }
    }

    //interface
    interface Iemployee
    {
           void display_details();
           decimal total_salary();
    }

    //derived class
     class salary_details :Iemployee
    {
        string name;
        int id;
        private decimal base_pay;
        private decimal hrapay;
        private decimal dapay;
        private decimal salary;
        public salary_details(string n,int i,decimal a,decimal b,decimal c)
        {
            name = n;
            id = i;
            base_pay =a;
            hrapay =b;
            dapay =c;
        }
        //implememting the interface class
        public decimal total_salary()
        {
            salary = base_pay + hrapay + dapay;
            return salary;
        }
        public void display_details()
        {
            Console.WriteLine("EMPLOYEE DETAILS");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("id:" + id);
            Console.WriteLine("salary:" + salary);
        }
    }
}
