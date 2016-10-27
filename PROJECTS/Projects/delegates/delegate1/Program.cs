using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//to get a list of odd/even numbers from a list of integers using delegates
namespace delegate1
{
    class Program
    {
        //declaring a delegate
        public delegate void del(List<int> l);
       
        static void Main(string[] args)
        {
            //creating a list of integers
            List<int> l = new List<int>();
            int i, j, n;
            //creating object of delegate
            del d = new del(delegate_class.delegate_method_even);
            Console.WriteLine("Enter the number of integers");
            n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Enter the list of integers");
                for (j=0;j<n;j++)
                {
                   i=int.Parse( Console.ReadLine());
                   l.Add(i);        //adding the elements in the list 
                }
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1.even");
                Console.WriteLine("2.odd");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    delegate_class.even(l, d);
                }
                else if (c==2)
                {
                    delegate_class.odd(l, d);
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    static class delegate_class
    {
        static public void even(List<int> l, Program.del d1)
        {
            d1(l);
        }
        static public void odd(List<int> l, Program.del d1)
        {
            //referencing the odd function to the delegate object
           //removing the even method from the delegate
            d1 += delegate_method_odd;
            d1 -= delegate_method_even;
            d1(l);
        }

        //even function
        static public void delegate_method_even(List<int> l)
        {
            Console.WriteLine("even method invoked");
            foreach (int k in l)
            {
                if(k%2==0)
                {
                    Console.WriteLine(k);
                }
            }
        }

        //odd function
        static public void delegate_method_odd(List<int> l)
        {
            Console.WriteLine("Odd method invoked");
            foreach (int k in l)
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
