using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    //Array List implementation
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();   //creating an object of array list class
            Console.WriteLine("Enter the number of elements to add in the array list");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values (any type)");
            for(int i=0;i<n;i++)
            {
                var a = Console.ReadLine();
                al.Add(a);                  //adding values to array list
            }
            Console.WriteLine("the elements in the array list are");

            //iterating through array list
            foreach(var v in al)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Enter the value to remove from the list");
            var value = Console.ReadLine();
            if (al.Contains(value))
            {
                //removing from the list
                al.Remove(value);
                Console.WriteLine("The list after deletion");
                foreach (var v in al)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("The value is not present in the list");
            }
            Console.WriteLine("Enter the value to insert into the list");
            var v1 = Console.ReadLine();
            Console.WriteLine("Enter the index to insert the value");
            int index = int.Parse(Console.ReadLine());
            if (index <= al.Count)
            {
                //inserting value into list
                al.Insert(index, v1);
                Console.WriteLine("The list after insertion");
                foreach (var v in al)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            Console.WriteLine("--Sort---");
            //sort function in list
            al.Sort();
            Console.WriteLine("After sorting, the list is");
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
