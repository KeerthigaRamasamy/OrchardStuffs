using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//array list implementation
namespace collections_trello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            char[] d = new char[3]; d[0] = ' '; d[1] = ',';d[2] = '.';

            //array list
            ArrayList al = new ArrayList();
            int ln = s.Length;
            //string split function
            string[] s1 = s.Split(d);
            foreach (string c in s1)
            {
                if (al.Contains(c))
                {
                    //removing duplicates
                    al.Remove(c);
                }
                else
                {
                    //adding into the array list
                    al.Add(c);
                }
            }
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }
        }
    }
}
