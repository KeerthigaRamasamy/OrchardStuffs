using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//delegates and anonymous methods
namespace Anonymous_methods
{
    class Program
    {

        //declaring a delegate
        //specifying that the function that the delegate points to returns void and it takes 1 parameter
        delegate void del(string s);
        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("------Anonymous methods and Delegates-------");
            Console.WriteLine("Enter a string to pass as argument to the delegate function");
            str = Console.ReadLine();

            //instanciating the delegate to point to the function named fun()
            del d = new del(fun);

            // making the delegate point to an anonymous method
            del d1 = delegate (string s2) { Console.WriteLine("Anonymous method called , The string is"+" "+s2); };

            //calling the anonymous method
            d(str);
            d1(str);

            List<employee> emp_list = new List<employee>() { new employee("Keerthi",1,21),
                                                             new employee("Karthik",2,22),
                                                             new employee("anu",3,21),
                                                             new employee("pooja",4,22),
                                                           };
            int i;i = 4;
            Console.WriteLine("The employee id is");

            //lambda expressions(we don't have to specify the type of the input parameter)
            employee e = emp_list.Find(emp => emp.id == i);
            Console.WriteLine(e.id);

            //using anonymous method doing the same thing
            employee e3 = emp_list.Find(delegate (employee e4) { return (e4.id == i); });
            Console.ReadKey();
        }

        //function 
        public static void fun(string s1)
        {
            Console.WriteLine("The function is called using delegate" + " " + "The string is" + " " + s1);
        }
    }
    public class employee
    {
        public string name;
        public int id;
        public int age;
        public employee(string name,int id,int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    }
}
