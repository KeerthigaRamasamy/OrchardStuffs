using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Exception handling*/

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,i,index=0,s,sqrt=0;
            float d=0;
            int[] arr = new int[5];
                Console.WriteLine("Enter the array elements(5) to test exception handling");
                for (i = 0; i < 5; i++)
                {
                while (true)
                {
                    try
                    {
                        while (!(int.TryParse(Console.ReadLine(), out arr[i])))
                            throw new FormatException("Invalid format");
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);     //format exception  
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry,enter again");     //generic exception            
                    }
                }
                }
                try
                {
                Console.WriteLine("Enter the index of the array to print the value at");
                while (!(int.TryParse(Console.ReadLine(), out index)))
                        throw new FormatException("Index should be an integer value");    
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            try
            {
                Console.WriteLine(arr[index]);
            }
            catch(IndexOutOfRangeException e)                     //index out of range exception
            {
                Console.WriteLine(e.Message);
                
            }
                    try
                    {
                        Console.WriteLine("Enter the values of a  for division");
                        while (!(int.TryParse(Console.ReadLine(), out a)))
                                Console.WriteLine("Enter valid integer value");
                         Console.WriteLine("Enter the values of b for division");
                         while (!(int.TryParse(Console.ReadLine(), out b)))
                                Console.WriteLine("Enter valid integer value"); 
                        d = a / b;                                      //dividing a by b  
                    }         
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);     //format exception
                       
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);    //divide by zero exception 
                        d = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry");     //other generic exceptions
                      
                    }
                    finally
                    {
                        Console.WriteLine("the result of the division is" + d);     //printing the value of the division
                    }   
                try
                {
                    Console.WriteLine("Enter the value to calculate square root");
                    while (!(int.TryParse(Console.ReadLine(), out s)))
                        throw new FormatException("Enter only integer values");
                    if (s < 0)
                    {
                       
                        throw (new negativenumber_exception());     //throwing custom exception
                    }
                    sqrt = (int)Math.Sqrt(s);                   //square root
                }
                catch(FormatException e)        //format exception
                {
                    Console.WriteLine(e.Message);
                }
                catch(negativenumber_exception e)                 //custom exception
                {
                    Console.WriteLine(e.Message);  
                }
                finally
                {
                    //sqrt = (int)Math.Sqrt(s);        //calculating square root
                    Console.WriteLine("the result of the square root is" + sqrt);
                }
            Console.ReadKey();
        }
    }

    /* Custom exception*/
    public class negativenumber_exception :System.Exception            //custom exception
    {
        public negativenumber_exception() :base()                      //constructor
        {

        }
        public negativenumber_exception(string message) :base(message)
        {
            message = "Negative Number Exception";     
        }
    }
}
