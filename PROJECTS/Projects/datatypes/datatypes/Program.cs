using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers a and b for performing opeartions");
            int a, b,c;
            while(!(int.TryParse(Console.ReadLine(),out a)))
            {
                Console.WriteLine("Invalid entry");
            }
            while (!(int.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("Invalid entry");
            }
            
            //AND operation
            c = a & b;
            Console.WriteLine("Result of binary AND operation is" + c);

            //OR operation
            c = a | b;
            Console.WriteLine("Result of binary OR operation is" + c);

            //XOR operation
            c = a ^ b;
            Console.WriteLine("Result of binary XOR operation is" + c);

            //LEFT SHIFT operation
            c = a << 2;
            Console.WriteLine("Result of left shift operation is" + c);

            //RIGHT SHIFT operation
            c = a >> 2;
            Console.WriteLine("Result of right shift operation is" + c);
        }
    }
}
