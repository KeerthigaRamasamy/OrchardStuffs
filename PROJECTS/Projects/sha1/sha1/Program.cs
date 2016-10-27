using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace sha1
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            string s1="",s2;
            int flag = 1;
            do
            {
                try
                {
                    Console.WriteLine("Enter the password");
                    s1 = Console.ReadLine();
                    flag = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid entry"); flag = 1;
                }
            } while (flag == 1);
            byte[] a=new byte[1024];
            byte[] r;

            a=Encoding.ASCII.GetBytes(s1);              //converting string to byte array
            SHA1 sha = new SHA1CryptoServiceProvider(); //creating object for crypto service provider
            r=sha.ComputeHash(a);                       //compute hash value
            s2=Encoding.ASCII.GetString(r,0,r.Length);   //converting byte array to string

            Console.WriteLine("The encrypted password is");
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
