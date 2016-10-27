using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnum
{
    class MainProgram
    {

        public static void Main(string[] args)
        {
            NumberGenerator generator = new NumberGenerator();
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a Positive Integer");
                number = Convert.ToInt32(Console.ReadLine()); ;

            } while (number <= 0);

            int reverseNumber = generator.findReverse(number);

            Console.WriteLine("Reverse of Number " + number + " is: " + reverseNumber);
        }

    }
    class NumberGenerator
    {


        public virtual int findReverse(int numb)
        {
            int n;
            n = numb;
            int count = 0, i = 0, s, j, r;
            while (n != 0)
            {
                n = n / 10;
                count++;
            }
            j = count-1;
           
            i = 0; 
            s = 0;
            
            Console.WriteLine("The number of digits in the number is" + count);
       
            while (i < count)
            {
                r = numb % 10;
                s = s + r *(int)(Math.Pow(10,j));
                i++;
                j--;
                numb = numb / 10;
            }
            Console.WriteLine("The sum value is" + s);
            return s;
            if(nu)
        }

    }
}
