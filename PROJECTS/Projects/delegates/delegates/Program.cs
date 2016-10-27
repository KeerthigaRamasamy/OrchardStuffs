using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegates
namespace delegates
{ 
    class delegate_class
    {
        //delcaring the delegate
        public delegate void delName();
        static public void delegate_method()
        {
            Console.WriteLine("Delegate method invoked");
        }
    }
    class program
    {
       public static void Main()
        {
            //creating object for the delegate
            delegate_class.delName obj = new delegate_class.delName(delegate_class.delegate_method);
            //invoking the delegate method
            obj();
            Console.Read();
        }
    }
}
