using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c=0,flag;
            while (true)
            {
                do
                {

                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Compare");
                Console.WriteLine("2.Copy");
                Console.WriteLine("3.Concatenate");
                Console.WriteLine("4.split");
                Console.WriteLine("5.substring");
                Console.WriteLine("6.exit");
                  try
                    {
                        c = int.Parse(Console.ReadLine());
                        flag = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry"); flag = 1;
                    }
                } while (c <= 0 || c > 7 || flag == 1);

                switch (c)
                {
                    case 1:
                        string s1 = "", s2 = "";
                        Console.WriteLine("String Compare");
                        flag = 1;
                        while (flag == 1)
                        {
                            Console.WriteLine("Enter two strings");
                            try
                            {
                                s1 = Console.ReadLine();
                                s2 = Console.ReadLine(); flag = 0;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry"); flag = 1;
                            }
                        }
                        if (String.Compare(s1, s2) == 0)
                        {
                            Console.WriteLine("Strings are equal");
                        }
                        else
                        {
                            Console.WriteLine("Strings are not equal");
                        }
                        break;

                    case 2:

                        string a1 = "", a2 = "";
                        Console.WriteLine("String Copy");
                        flag = 1;
                        while (flag == 1)
                        {
                            Console.WriteLine("Enter the string");
                            try
                            {
                                a1 = Console.ReadLine();
                                flag = 0;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry"); flag = 1;
                            }
                        }
                        a2 = String.Copy(a1);             //string copy function
                        Console.WriteLine("The copied string is");
                        Console.WriteLine(a2);
                        break;

                    case 3:

                        string b1 = "", b2 = "", b3 = "";
                        Console.WriteLine("String Concatenation");
                        flag = 1;
                        while (flag == 1)
                        {
                            Console.WriteLine("Enter two strings");
                            try
                            {
                                b1 = Console.ReadLine();
                                b2 = Console.ReadLine();
                                flag = 0;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry"); flag = 1;
                            }
                        }
                        b3 = String.Concat(b1, b2);         //concatenation function
                        Console.WriteLine("The concatenated string is" +"\t"+ b3);
                        break;

                    case 4:
                        string c1 = "";
                        Console.WriteLine("String splitting");
                        flag = 1;
                        while (flag == 1)
                        {
                            Console.WriteLine("Enter the string");
                            try
                            {
                                c1 = Console.ReadLine();
                                flag = 0;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry"); flag = 1;
                            }
                        }
                        Console.WriteLine("The splitted strings are");
                        string[] c2 = c1.Split(' ');        //split function
                        foreach (string s in c2)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case 5:
                        string d1 = "";
                        int st = 0, l = 0;
                        Console.WriteLine("Substring");
                        flag = 1;
                        while (flag == 1)
                        {
                            Console.WriteLine("Enter the string");
                            try
                            {
                                d1 = Console.ReadLine();
                                flag = 0;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry"); flag = 1;
                            }
                        }
                        Console.WriteLine("Enter the start index and the length to be splitted");
                        int flag1 = 1, length = 0;
                        do
                        {
                            try
                            {
                                st = int.Parse(Console.ReadLine());
                                l = int.Parse(Console.ReadLine()); flag1 = 0;
                                length = d1.Length;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid entry"); flag1 = 1;
                            }
                        }
                        while (flag1 == 1 || st > length || l > length || st < 0);
                        Console.WriteLine("The substring is");
                        string d2 = d1.Substring(st, l);
                        Console.WriteLine(d2);

                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
