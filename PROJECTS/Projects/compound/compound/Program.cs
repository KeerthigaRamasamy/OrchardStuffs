using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int p=0;      //principle
            decimal p = 0;
            float t=0; //period     
            double r=0;//rate
            calculation c=new calculation();        //creating object of class calculation
            c.compound_interest(p, t, r);
            Console.ReadKey();
        }
    }
    /*class to calculate compound interest*/
     public class calculation
    {
        public void compound_interest(decimal p,float t,double r)
        {
            float c,c1;
            //implicit type casting
            double c2,c3;
            do
            {
                    Console.WriteLine("Enter the principal amt"); //getting the values
                    while(!(decimal.TryParse(Console.ReadLine(),out p)))
                    {
                        Console.WriteLine("Enter valid integer values");
                    }
                    Console.WriteLine("Enter the rate");
                    while (!(double.TryParse(Console.ReadLine(), out r)))
                    {
                        Console.WriteLine("Enter valid double values");
                    }
                    Console.WriteLine("Enter the period in years");
                    while (!(float.TryParse(Console.ReadLine(), out t)))
                    {
                        Console.WriteLine("Enter valid float values");
                    } 
            } while ((p <= 0) || (r <= 0) || (t <= 0));  //boundary condition handling

            /*explicit type casting*/
            c1 = (1 + ((float)r/ 100));    //converting to float    
            c3 = (double)p;
            c2 = (Math.Pow((double)c1, r))*c3;  //converting to double
            c = (float)c2;
            c3 = (int)c2;

            /*printing the values*/
            Console.WriteLine("The compound interest value in integer is" + " " + c3);
            Console.WriteLine("The compound interest value in float is" + " " + c2);   //printing the value in float
            Console.WriteLine("The compound interest value in double is" + " " + c);  //printing the value in double
        }
    }
}





//c2 = Math.Pow((double)c1, r);
////c = (float)c2 * (float)p;
////c3 = c2 * (double)p;
