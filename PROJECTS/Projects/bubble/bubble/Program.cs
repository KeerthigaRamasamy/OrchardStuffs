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
        int[] a = new int[6];
        int n,i,j,k,temp;
        Console.WriteLine("Enter the array of numbers");
            for(i=0;i<6;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        for(j=0;i<6;j++)
            {
                for(k=0;k<6-j-1;k++)
                {
                    if(a[k]>a[k+1])
                    {
                        temp=a[k];
                        a[k]=a[k+1];
                        a[k+1]=temp;
                    }
                    Console.WriteLine(a[k]);
                } 
            }
           for(i=0;i<6;i++)
            {
                Console.WriteLine(" " + a[i] + " ");
            }

    }

        }
    }
