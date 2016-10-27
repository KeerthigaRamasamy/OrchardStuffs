using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using interface to show multiple inheritance

namespace multiple_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two integers for calculation");
            while (!(int.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Enter only valid integer value");
            }
            while (!(int.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine("Enter only valid integer value");
            }
            calculation obj = new calculation(x, y);
            int a = obj.result1;
            int b = obj.result2;
            int c = obj.result3;
            Console.WriteLine("The result of addition is" + " " + a);
            Console.WriteLine("The result of multiplication is" + " " + b);
            Console.WriteLine("The result of division is" + " " + c);
            Console.ReadKey();
        }
    }

    //interface
    interface a
    {
        int add();
    }
    interface b
    {
        int sub();
    }
    interface c
    {
        int mul();
    }

    //class inheriting the interfaces
    public class calculation : a, b, c
    {
        public int x,y,result1,result2,result3;

        public calculation(int x1,int y1)
        {
            x = x1;
            y = y1;
        }
        int a.add()
        {
            result1 = x + y;
            return result1;
        }
        int c.mul()
        {
            result2 = x * y;
            return result2;
        }
        int b.sub()
        {
            result3 = x - y;
            return result3;
        }

    }
}
