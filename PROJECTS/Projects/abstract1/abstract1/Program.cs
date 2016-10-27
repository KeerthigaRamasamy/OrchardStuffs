using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object for derived class
            derived_class d = new derived_class();
            d.m1();         //accessing the base class methods using derived class object
            d.m2(); 
        }
    }
    abstract class abc      //abstract class
    {
        public abstract void m1();  //abstract class methods(virtual)
        public abstract void m2();
    }
    class derived_class:abc
    {
        public override void m1()       //implementation(overriding the virtual method)
        {
            Console.WriteLine("Abstract class implementation1");
        }
        public override void m2()       //implementation
        {
            Console.WriteLine("Abstract class implementation2");
        }
    }
}
