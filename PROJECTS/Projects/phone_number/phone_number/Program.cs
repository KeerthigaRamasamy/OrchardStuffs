using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] a=new string[10];
            int length,i;
            a[0] = "ZERO"; a[1] = "ONE"; a[2] = "TWO"; a[3] = "THREE"; a[4] = "FOUR";
            a[5] = "FIVE"; a[6] = "SIX"; a[7] = "SEVEN"; a[8] = "EIGHT"; a[9] = "NINE";
            string input = "",copy="";
            Console.WriteLine("Enter the string");
            input = Console.ReadLine();
            length = input.Length;
            for (i = 0; i < length; i++)
            {
                length = input.Length;
                if(input[i]=='Z')
                {

                }
                else if(input[i]=='O')
                {

                }
                else if (input[i] == 'T')
                {

                }
                else if (input[i] == 'F')
                {

                }
                else if (input[i] == 'S')
                {

                }
                else if (input[i] == 'E')
                {

                }
                else if (input[i] == 'N')
                {

                }
                else
                {
                    Console.WriteLine("Invalid string");
                }
            }

        }
    }
}
