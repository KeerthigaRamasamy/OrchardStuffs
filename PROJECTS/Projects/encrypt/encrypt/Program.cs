using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* encrypting the password to a cipher text*/
namespace encrypt
{
    class Program
    {
        #region main function
        public static void Main(string[] args)
        {
            string s3,s1,s2;
            bool flag, flag1,flag2;
            char[] k=new char[50];
            char[] p=new char[50];
	        char[] a=new char[26];
            int[] n=new int[26];
            int l1,l2, sum = 0, i, j, f;
            s3 = "abcdefghijklmnopqrstuvwxyz";
            do
            {
                Console.WriteLine("Enter the password");        //getting the password
                s1 = Console.ReadLine();
                 flag = s1.All(char.IsLetter);
                 flag1 = s1.All(char.IsLower); 
            } while (flag == false || flag1==false);
            do
            {
            Console.WriteLine("Enter the key");                 //getting the key
            s2 = Console.ReadLine();
            flag1 = s1.All(char.IsLetter);
            flag2 = s1.All(char.IsLower);
            } while (flag1 == false || flag2==false);
	        p = s1.ToCharArray();
	        k = s2.ToCharArray();
            a = s3.ToCharArray();
            l1 = p.Length;              //finding the length of the password and the key
            l2 = k.Length;
            for (i = 0; i < 26; i++)
            {
                n[i] = i;               //assigning numbers to n from 0 to 25
            }
	        for (j = 0; j < l2; j++)
	            {
		           for (i = 0; i < 26; i++)
		               {
			            if (k[j] == a[i])
			                {
                                k[j] = (char)i;    //assigning values to each letter of the key
			                }
		                }
	            }
	        for (i = 0; i < l2; i++)
	            {
		            sum = sum +(int) k[i];      //adding each values of the key,store it in sum
	            }
	        f = sum % 26;                       //taking modulo to the sum value=f
	        for (j = 0; j < l1; j++)
	            {
		            for (i = 0; i < 26; i++)
		                {
			                if (p[j] == a[i])
			                    {
				                    if ((i + f) < 26)
					                p[j] = (char)(i + f); //assigning values(value+f) to each letter in password
				                    else
					                p[j] = (char)((i + f)-(26));
			                    }
		                }
	            }
                Console.WriteLine("");
	            Console.WriteLine("The encrypted word is");
                for (j = 0; j < l1; j++)
	                {
		                for (i = 0; i < 26; i++)
		                    {
			                    if ((int)p[j] == n[i])
			                        {
				                      p[j] = a[i];
				                      Console.Write(p[j]);   //printing the encrypted word
			                        }
		                    }
	                }
                Console.WriteLine(" ");
                for (j = 0; j < l1; j++)
                {
                    for (i = 0; i < 26; i++)
                    {
                        if (p[j] == a[i])
                        {
                            if ((i - f) >= 0)
                                p[j] = (char)(i - f); //assigning values(value+f) to each letter in password
                            else
                                p[j] = (char)((i - f) +(26));
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine(" " +"The decrypted word is");
                for (j = 0; j < l1; j++)
                {
                    for (i = 0; i < 26; i++)
                    {
                        if ((int)p[j] == n[i])
                        {
                            p[j] = a[i];
                            Console.Write(p[j]);   //printing the decrypted word
                        }
                    }
                }

                Console.ReadKey();
        }
        #endregion
    }
}
