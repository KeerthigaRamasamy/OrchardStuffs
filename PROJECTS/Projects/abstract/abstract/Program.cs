using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//overloading, overriding, abstract class ,inheritance
namespace @abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c,area1;
            double area2;
            Console.WriteLine("Enter the dimensions of the rectangle");
            a = int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the circle");
            c= int.Parse(Console.ReadLine());
            //creating object of the derived class
            rect obj=new rect();
            area1=obj.area(a,b);        //accessing the base class method using derived class object
            area2 = obj.area(c);        //function overloading
            Console.WriteLine("The area of the rectangle is"+c);
        }
    }

    //abstract class
    abstract class abs
    {
        public abstract int area(int a,int b);
        public abstract double area(int r);
    }

    //inherited class
    class rect:abs
    {
        private int breadth;
        private int length;
        public rect()
        {
            breadth = 0;
            length = 0;
        }

        //implementation of abstract class method
        public override int area(int a, int b)      //area of rectangle
        {
            int result;
            length = a;
            breadth = b;
            result = length*breadth;
            return result;
        }
        //implementation of abstract class method
        public override double area(int r)      //area of circle
        {
            double result;
            result = (3.14) * (r*r);
            return result;
        }
    }
}
