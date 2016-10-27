using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            ArrayList al = new ArrayList();
            int ln = s.Length;
            string[] s1 = s.Split(' ');
            foreach(string c in s1)
            {
                if (al.Contains(c))
                {
                    al.Remove(c);
                }
                else
                {
                    al.Add(c);
                }
            }
            foreach(var v in al)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
