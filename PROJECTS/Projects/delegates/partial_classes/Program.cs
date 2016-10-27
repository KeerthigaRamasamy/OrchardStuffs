using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//partial classes and methods
namespace partial_classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "Hello world";
            //creating object of partial class
            c1 obj = new c1();
            c1 obj1 = new c1(s);
            obj.method2();
            obj.method3();
            Console.ReadKey();
        }
    }
    //partial class 1
    public partial class c1
    {
        public c1(string s)
        {
            Console.WriteLine("Partial class1 constructor !!");
            Console.WriteLine(s);
        }
        //partial method
        partial void method1();  
        public void method2()
        {
            Console.WriteLine("Method2 of partial class called");
        }
    }

    //partial class 2
    public partial class c1
    {
        public c1()
        {
            Console.WriteLine("Partial class constructor!!");
        }
        //implementation of partial method
        partial void method1()
        {
            Console.WriteLine("Method1 of partial class called");
        }
        public void method3()
        {
            Console.WriteLine("Method3 of partial class called");
        }
    }
}
