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
            int n, i, s,e;
            do
            {
            t1: try
                {
                    Console.WriteLine("Enter the number of elements");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid entry");
                    goto t1;
                }
                catch(Exception)
                {
                    Console.WriteLine("invalid entry");
                    goto t1;
                }
            } while (n <= 0);
            int[] a = new int[n];
            Console.WriteLine("Enter the numbers");
            for(i=0;i<n;i++)
            {
            t2: try
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("invalid entry,enter again");
                    goto t2;
                }
            }
            s=0;e=n-1;
           o.quicksort(a,s,e);
           o.display(a,n);
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
        public void display(int[] a,int n)
        {
            Console.WriteLine("The sorted array is");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}


 
