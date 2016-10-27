using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n,i, j, k, temp;
            Console.WriteLine("Enter the number of elements");
            while (!(int.TryParse(Console.ReadLine(),out n)))
            {
                Console.WriteLine("Enter the number of elements");
            } 
             Console.WriteLine("Enter the array of numbers");
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                while (!(int.TryParse(Console.ReadLine(), out a[i])))
                {
                    Console.WriteLine("Enter again");
                }
            }
            for (j = 0; j < n; j++)
            {
                for (k = 0; k < n - j - 1; k++)
                {
                    if (a[k] > a[k + 1])
                    {
                        temp = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = temp;
                    }
                    
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" " + a[i] + " ");
            }

        }

    }
}
