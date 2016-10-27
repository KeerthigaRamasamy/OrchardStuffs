using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = " ";
            lastword obj = new lastword();
            while (true)
            {
                Console.WriteLine("Enter the string");
                a = Console.ReadLine();
                obj.algorithm(a);
                Console.WriteLine();
            }
        }
    }
    public class lastword
    {
        public void algorithm(string a)
         {
            int length = a.Length;
            int i,j=0;
            //char[] b = new char[length];
            string b;
            char first;
            //first = a[0];
            //b[0] = first;
            for(i=1;i<length;i++)
            {
                first = b[0];
                if(a[i]>=first && j<length)
                {
                    b[0] = a[i];
                    string c = Convert.ToString(b[0]);
                    //Console.WriteLine(c);
                    string d = Convert.ToString(b);
                    //Console.WriteLine(c);
                    string e = c + d;
                    //Console.WriteLine(c);
                    //b = e.ToCharArray();
                    b = e;
                    //b[j + 1] = first;
                    //j = j + 2;
                }
                else if(j<length)
                {
                    b[i] = a[i];
                    j++;
                }
            }
            for (i = 0; i < length; i++)
            {
                Console.Write(b[i]);
            }
         }
    }
}
