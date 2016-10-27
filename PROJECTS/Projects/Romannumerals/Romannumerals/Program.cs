using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romannumerals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string roman1="", roman2="";
            int flag=1;
            while(flag==1)
            {
            try
            {
                Console.WriteLine("Enter two roman numbers");
                roman1 = Console.ReadLine();
                roman2 = Console.ReadLine();
                flag=0;
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid entry");flag=1;
            }
            }
            int n1 = convert(roman1);
            int n2 = convert(roman2);
            int n3 = n1 + n2;
            Console.WriteLine("The addition of the two roman numerals are" + n3);
        }


        public static int roman(char c)
        {
            int i;
            switch(c)
            {
                case 'I':
                    i = 1;
                    return i;
                    break;
                case 'V':
                    i = 5;
                    return i;
                    break;
                case 'X':
                    i = 10;return i;
                    break;
                case 'L':
                    i = 50;return i;
                    break;
                case 'C':
                    i = 100;return i;
                    break;
                case 'D':
                    i = 500;return i;
                    break;
                case 'M':
                    i = 1000;return i;
                    break;
                default:
                    Console.WriteLine("Invalid roman number");
                    return 0;
            }
        }
        public static int convert(string roman1)
        {
            int num=0, j,l1;
            char[] r1 = roman1.ToCharArray();
            l1 = roman1.Length;
            j = l1 - 1;
            num = roman(r1[j]);
            for (j = l1 - 1; j > 0; j--)
            {
                if(roman(r1[j])<=roman(r1[j-1]))
                {
                    num = num + roman(r1[j - 1]);
                }
                else
                {
                    num = num - roman(r1[j - 1]);
                }
            }
            return num;
        }
    }
}
