using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius, width, length;
            //float f=0;
            Console.WriteLine("Enter the length and breadth of the rectangle");
            while(!(int.TryParse(Console.ReadLine(),out width)) || width <=0)
            {
                Console.WriteLine("Invalid");
            }
            while (!(int.TryParse(Console.ReadLine(), out length)) || length <= 0)
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter the radius");
            while (!(int.TryParse(Console.ReadLine(), out radius)) || radius <= 0)
            {
                Console.WriteLine("Invalid");
            }
            //width = int.Parse(Console.ReadLine());
            //length = int.Parse(Console.ReadLine());
            
            //radius = int.Parse(Console.ReadLine());

            //calling the constructors
            area_calc obj1 = new area_calc(width,length);       //consructor overloading
            area_calc obj2 = new area_calc(radius);
            //area_calc obj3 = new area_calc(f);
            obj1.calc_rect();
            obj2.calc_circle();
            obj1.print_rect();
            obj2.print_circle();
            Console.ReadKey();
        }
    }

    //abstract class
    abstract public class shape
    {
        public abstract void calc_rect();
        public abstract void calc_circle();
        public abstract void print_circle();
        public abstract void print_rect();
    }

    //inheritacnce
    public class area_calc:shape
    {
        int area_rectangle,radius,width,length;
        double area_circle;

        //constructor overloading
        public area_calc(int r)
        {
            radius = r;
        }
        public area_calc(int a,int b)
        {
            width = a;
            length = b;
        }
        //public area_calc(float c)
        //{

        //}
        //method overriding(implementing the abstract methods)
        public override void calc_circle()
        {
            area_circle = 3.14 * radius * radius;
        }
        public override void calc_rect()
        {
            area_rectangle = width * length;
        }
        public override void print_circle()
        {
            Console.WriteLine("The area of the circle is" + area_circle);
        }
        public override void print_rect()
        {
            Console.WriteLine("The area of the rectangle is" + area_rectangle);
            
        }
    }
}
