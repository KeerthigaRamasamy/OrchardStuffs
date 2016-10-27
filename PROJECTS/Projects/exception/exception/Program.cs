using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class Program
    {
        public static void Main(string[] args)
        {
            sort o = new sort();
            int n, i, s, e,flag=1;
            int[] a=new int[50];;
           
                Console.WriteLine("Enter the number of elements");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the numbers");
                for (i = 0; i < n; i++)
                {
                    flag = 1;
                    while(flag==1)
                    {
                        try
                        {

                            a[i] = Convert.ToInt32(Console.ReadLine()); flag = 0;
                        }


                       catch (Exception)
                        {
                            Console.WriteLine("invalid number");
                            flag = 1;

                        }
                    }
           
                 }
            s = 0; e = n - 1;
            o.quicksort(a, s, e);
            o.display(a, n);
            Console.ReadKey();
        }
    }
    class sort
    {
        int i, pivot, pi, temp;
        public void quicksort(int[] a, int s, int e)
        {

            if (s <= e)
            {
                pi = partition(a, s, e);
                quicksort(a, s, pi - 1);
                quicksort(a, pi + 1, e);
            }
        }
        public int partition(int[] a, int s, int e)
        {
            pivot = a[e];
            pi = s;
            for (i = s; i < e; i++)
            {
                if (a[i] <= pivot)
                {
                    temp = a[pi];
                    a[pi] = a[i];
                    a[i] = temp;
                    pi = pi + 1;
                }
            }
            temp = a[e];
            a[e] = a[pi];
            a[pi] = temp;
            return pi;
        }
        public void display(int[] a, int n)
        {
            Console.WriteLine("The sorted array is");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}


 

