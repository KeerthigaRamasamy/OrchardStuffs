using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            string[] s1 = new string[10];
            
            //calling extension method
            s1=str.split_into_two();
            Console.WriteLine("The splitted string is");
            foreach(string s in s1)
                Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
