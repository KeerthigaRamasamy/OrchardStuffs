using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string local_address;
            string state;
            long pincode;
            long contact_number;
            applicant obj;
            Console.WriteLine("----Details of applicant for an LIC use policy------");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the name of the applicant");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the age");
                    while (!(int.TryParse(Console.ReadLine(), out age)))
                    {
                        Console.WriteLine("Enter a valid integer");
                        Console.Clear();
                    }
                    if (age <= 10)
                    {
                        //throwing custom exception
                        //throw new ApplicantAgeLessthanTenException("Application age cannot be less than 10");
                        throw new Exception("Application age cannot be less than 10");
                    }
                    Console.WriteLine("Enter the local address");
                    local_address = Console.ReadLine();
                    Console.WriteLine("Enter the state");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter the pincode");
                    while (!(long.TryParse(Console.ReadLine(), out pincode)))
                    {
                        Console.WriteLine("Enter a valid pincode");
                        Console.Clear();
                    }

                    //throwing custom exception
                    if ((pincode.ToString()).Length != 6)
                    {
                        throw new InvalidPinCodeException();
                    }
                    Console.WriteLine("Enter the contact number");
                    while (!(long.TryParse(Console.ReadLine(), out contact_number)))
                    {
                        Console.WriteLine("Enter a valid contact number");
                        Console.Clear();
                    }
                    obj = new applicant(name, age, local_address, state, pincode, contact_number);
                    Console.WriteLine("Enter two numbers for division");
                    int i, j, k;
                    while (!(int.TryParse(Console.ReadLine(), out i)))
                        Console.WriteLine("Invalid");
                    while (!(int.TryParse(Console.ReadLine(), out j)))
                        Console.WriteLine("Invalid");
                    k = i / j;
                    break;
                }
                catch (InvalidPinCodeException)                             //format exception
                {
                    //custom exception caught
                }
                catch (ApplicantAgeLessthanTenException)        //catching custom exception
                {
                    //custom exception caught
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            Console.WriteLine("Name"+"\t"+"Age"+"\t"+"address"+"\t"+"state"+"\t"+"pincode"+"\t"+"number");
            Console.Write(obj.name + "\t" + obj.age + "\t" + obj.local_address + "\t" + obj.state + "\t" + obj.pincode + "\t" + obj.contact_number + "\t");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
    public class applicant
    {
        public string name;
        public int age;
        public string local_address;
        public string state;
        public long pincode;
        public long contact_number;
        public applicant(string n,int a,string la,string s,long p,long ph)
        {
            name = n;
            age = a;
            local_address = la;
            state = s;
            pincode = p;
            contact_number = ph;
        }
    }

    //custom exception implementation
    public class ApplicantAgeLessthanTenException:Exception
    {
        public ApplicantAgeLessthanTenException()
        {
            Console.WriteLine("Application age cannot be less than 10");
        }
        public ApplicantAgeLessthanTenException(string message) :base (message)
        {
            Console.WriteLine(message);
        }
    }
    public class InvalidPinCodeException:Exception
    {
        public InvalidPinCodeException()
        {
            Console.WriteLine("Invalid Pincode Exception is thrown");
        }
        public InvalidPinCodeException(string message): base (message)
        {
            Console.WriteLine(message);
        }
    }
}
