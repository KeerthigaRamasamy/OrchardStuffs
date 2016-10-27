using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//asynchronous programming in c#
namespace async
{
    class Program
    {
        //main method
        public static void Main(string[] args)
        {
            Console.WriteLine("-------Asynchronous method example-------");
            async_method();                     //calling the asynchronous method
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("You have entered this string:");
            Console.WriteLine(s);
            Console.ReadKey();
        }
        
        //asynchronous method
        public static async void  async_method()
        {
            //run this task asynchronously
            await Task.Run(() => calculate());
        }

        //method to iterate the values and print
        public static void calculate()
        {
            long i=0;
            while(i < 1100000000)
            {
                i++;
            }
            Console.WriteLine("The count value after iterating through a long integer is");

            //printing the value
            Console.WriteLine(i);
        }
    }
}
