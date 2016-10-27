using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n, i, flag = 1, k, v, r, r1;
                int c;
                search o = new search();        //object of the class search
                Console.WriteLine("----Searching------");
                Console.WriteLine("1.Linear Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.WriteLine("-------------------");
                //bool check = int.TryParse(Console.ReadLine(), out c);
                while (!(int.TryParse(Console.ReadLine(), out c)) || c < 1 || c > 3)
                {
                    Console.WriteLine("Enter only values(1 or 2 or 3)");
                }
                
               
                switch (c)
                {
                    case 1:
                        do
                        {
                        t3: Console.WriteLine("Enter the array size for searching");
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid entry enter again");
                                goto t3;
                            }
                        } while (n <= 0);   //boundary condition
                        int[] a = new int[n];           //array declaration
                        Console.WriteLine("Enter the array elements ");
                        for (i = 0; i < n; i++)
                        {
                            flag = 1;
                            while (flag == 1)
                            {
                                try
                                {
                                    a[i] = int.Parse(Console.ReadLine());   //getting the array values
                                    flag = 0;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Invalid entry, enter the values again"); //exception handling
                                    flag = 1;
                                }
                            }
                        }
                    t: try
                        {
                            Console.WriteLine("Enter the value to be searched in the array elements");
                            k = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid entry, enter the key value again");
                            goto t;
                        }
                         r=o.linear(a, n, k);
                        //if (r ==0)
                         //    Console.WriteLine("The value is not found in the array");
                        //else
                        //    
                        break;
                    case 2:
                        Console.WriteLine("Enter the array size for searching");
                        do
                        {
                        t2: Console.WriteLine("");
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid entry enter again");
                                goto t2;
                            }
                        } while (n <= 0);   //boundary condition
                        int[] a1 = new int[n];           //array declaration
                        Console.WriteLine("Enter the array elements ");
                        for (i = 0; i < n; i++)
                        {
                            flag = 1;
                            while (flag == 1)
                            {
                                try
                                {
                                    a1[i] = int.Parse(Console.ReadLine());   //getting the array values
                                    flag = 0;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Invalid entry, enter the values again"); //exception handling
                                    flag = 1;
                                }
                            }
                        }
                        for (int j = 0; j < n; j++)
                        {
                            for (k = 0; k < n - j - 1; k++)
                            {
                                if (a1[k] > a1[k + 1])
                                {
                                    int temp = a1[k];
                                    a1[k] = a1[k + 1];
                                    a1[k + 1] = temp;
                                }

                            }
                        }
                        Console.WriteLine("The sorted array is");
                        for (i = 0; i < n; i++)
                        {
                            Console.WriteLine(" " + a1[i] + " ");
                        }
                    t1: try
                        {
                            Console.WriteLine("Enter the value to be searched in the array elements");
                            k = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid entry, enter the key value again");
                            goto t1;
                        }
                        //int[] array=new int[n];
                        r = o.binary(a1, 0, n - 1, k);
                        if (r == -1)
                            Console.WriteLine("The value is not found in the array"); 
                        else
                        {
                            for(i=0;i<r;i++)
                            {
                                if (a1[i] == k)
                                    Console.WriteLine("The value is present at position" + i);
                            }
                            Console.WriteLine("The value is present at position" + r);
                            for (i = r+1; i < n; i++)
                            {
                                if (a1[i] == k)
                                    Console.WriteLine("The value is present at position" + i);
                            }
                        }
                        //else
                        //{
                        //    for(i=0;i<n;i++)
                        //    {
                        //        if(array[i]!=0)
                        //        Console.WriteLine("The key is found at the position" + array[i]);
                        //    }
                        //}
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                    string s;
                    while (true)
                    {
                        Console.WriteLine("Do you want to continue (y/n)");
                        s = Console.ReadLine();
                        s.Trim();
                        //bool ch2 = s.All(char.IsLetter('y'));
                        //bool ch3 = s.All(char.IsLetter('n'));
                        bool ch = s.Contains('y'); 
                        bool ch1 = s.Contains('n'); 
                            if (ch == false && ch1 == false)
                                continue;
                            else if (ch1 == true)
                                Environment.Exit(0);
                            else if (ch == true)
                                break;
                            else
                                continue;
                               //Console.WriteLine("Enter only y/n");
                    }
                    //else
                    //    Console.WriteLine("Enter only y/n");
            }
        }
    }

    /* linear and binary search*/
    public class search
    {
        public int i=0;
        public int binary(int[] a,int s,int e,int k)    //binary search
        { 
            //int[] arr=new int[e];
            //int i;
                if (s > e)
                {
                    //int[] arr1 = new int[1];
                    //arr1[0] = -1;
                    return -1;
                }
                else
                {
                    int m;
                    m = (s + e) / 2;
                    //m = s + (e - 1) / 2;        //finding the middle index avlue
                    if (a[m] == k)
                    {
                        //arr[i] = m + 1;
                        //i++;
                        //int n = i;
                        // sort(arr,i);
                         //Console.WriteLine("The key is found at position" + (m + 1));
                         //binary(a, s, m - 1, k);
                         //binary(a, m+1, e, k);
                        //for(i=0;i<n;i++)
                        //Console.WriteLine("The key is found at the position"+arr[i]);
                        return m;
                    }
                    else if (k > a[m])      //checking if the key is in left or right sub array
                    {
                        // s = m + 1;
                        return binary(a, m + 1, e, k);
                    }
                    else
                    {
                        //e = m - 1;
                        return binary(a, s, m - 1, k);        //recursively calling the function
                    }
                }
        }
        public int linear(int[] a,int n,int k)      //linear search
        {
            int i,j=-1,flag=0;
            for(i=0;i<n;i++)
            {
                if(a[i]==k)
                {
                    j = i + 1;
                    Console.WriteLine("The value is found at the position" + j);
                    flag = 1;
                    //return i+1;
                }
            }
            return flag;
        }
        public void sort(int[] arr,int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n - j - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        int temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }
    }
}
