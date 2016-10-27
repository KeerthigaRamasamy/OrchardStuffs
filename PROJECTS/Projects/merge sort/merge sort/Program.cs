using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            sort o = new sort();

            int i,n;
            do{
            t:try
            {
            Console.WriteLine("Enter the number of elements");
            n=int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid entry, enter it again");
                goto t;
            }
            }while(n<=0);
            int[] a = new int[n]; 
            Console.WriteLine("Enter the array elements for merge sort");
            for(i=0;i<n;i++)
            {
                t1: try
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry, enter it again");
                        goto t1;
                    }
            }
            o.mergesort(a,0,n-1);                           //calling the mergesort function
            Console.WriteLine("The sorted array is");
            o.print(a,n);                                   //printing the sorted array
            Console.ReadKey();
        }
    }
    class sort
    {

        /*dividing the array into subarrays and sending to merge function*/
        public void mergesort(int[] a,int s,int e)
        {
            int m;
            if (s < e)
            {
                m = (e+s)/ 2;               //finding the mid index of the array
                mergesort(a, s, m);         //recursively calling
                mergesort(a, m + 1, e);
                merge(a, s, m, e);
            }
        }


        /*merging the subarrays*/
        public void merge(int[] a,int s,int m,int e)
        {
            int n1,n2,i,j,k;                          
            n1=(m - s)+1;                       //size of left subarray
            n2 = e - m;                         //size of right subarray
            int[] l=new int[n1];
            int[] r=new int[n2];
            for(i=0;i<n1;i++)
            {
                l[i] = a[s+i];                  //copying the elements from the main array to left subarray
            }
            for (j = 0; j < n2;j++ )
            {
                r[j] = a[m + 1 + j];           //copying the elements from the main array to right subarray
            }
            k = s;
            i = 0; j = 0;
                while(i < n1 && j < n2)        
                {
                    if (l[i] <= r[j])          //sorting and copying
                    {
                        a[k] = l[i];
                        i++;
                    }
                    else
                    {
                        a[k] = r[j];
                        j++;
                    }
                    k++;
                }
            while(i<n1)
            {
                a[k]=l[i];                  //copying the remaining elements
                i++;
                k++;
            }
            while(j<n2)
            {
                a[k] = r[j];                //copying the remaining elements
                j++;
                k++;
            }
        }

        /* printing the sorted array*/
        public void print(int[] a,int n)
        {
            int i;
            for(i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

