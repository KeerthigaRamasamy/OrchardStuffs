using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[6];
            int i;
            Console.WriteLine("Enter the array elements for insertion sort");
            for(i=0;i<6;i++)
                {
            t1:try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                catch(Exception)
                    {

                        Console.WriteLine("Invalid entry, enter it again");
                        goto t1;
                    }
                }  
           int hole,value;
            i=1;
            while(i<6)
            {
            value=a[i];
             hole=i;
            while(a[hole-1]>value && hole-1>0)
            {
                a[hole]=a[hole-1];
                hole=hole-1; 
            }
            a[hole]=value;
            i++;
            }
            Console.WriteLine("The sorted array is");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine(a[i]);
            }   
        }
    }
       
}
