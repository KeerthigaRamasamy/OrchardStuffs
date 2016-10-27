using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace unit_test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Enter two values for calculation");
            while(!(int.TryParse(Console.ReadLine(),out a)))
            {
                Console.WriteLine("Enter a valid integer value");
            }
            while (!(int.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("Enter a valid integer value");
            }
            calc obj = new calc();
            c=obj.add(a, b);
            Console.WriteLine("the addition of the two numbers is" + c);
            c =obj.mul(a, b);
            Console.WriteLine("the multiplication of the two numbers is" + c);
            c =obj.div(a, b);
            Console.WriteLine("the division of the two numbers is" + c);
            Console.ReadKey();
        }
    }
    public class calc
    {
        public int mul(int a,int b)
        {
            int c;
            c = a * b;
            return c;
        }
        public int add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        public int div(int a, int b)
        {
            int c=0;
            try
            {          
                    c = a / b;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();
                c = 0;
            }
            return c;
            
        }
    }
}
