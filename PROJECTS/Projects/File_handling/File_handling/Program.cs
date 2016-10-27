using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;


//program to create, read and write into files
namespace File_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            string path = ConfigurationManager.AppSettings["Path"];
            //string path = @"C:\Users\M1037727\Desktop\NewFile";
            Console.WriteLine("-------File handling----");

            //checking if the file actually exists or not
            if (!File.Exists(path))
            {
                Console.WriteLine("The file doesn't exists");
                Console.WriteLine("creating a new one");

                //creating a file in that particular path
                using (FileStream s = File.Create(path))
                {

                }
            }

            while (true)
            {
                Console.WriteLine("1.Write");
                Console.WriteLine("2.Read");
                Console.WriteLine("3.exit");
                while (!(int.TryParse(Console.ReadLine(), out c)) || c > 3 || c <= 0)
                    Console.WriteLine("Invalid, enter again");

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter the lines to  write into your file");
                        string s1 = Console.ReadLine();
                        string s2 = Console.ReadLine();
                        string s3 = Console.ReadLine();
                        try
                        {
                            //writing into the file 
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                //creating an object for streamwriter class
                                writer.WriteLine(s1);
                                writer.WriteLine(s2);
                                writer.WriteLine(s3);
                            }
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Reading from the file");
                        string buffer = "";

                        //reading from the file  using stream reader
                        try
                        {
                            using (StreamReader rdr = new StreamReader(path))
                            {
                                while ((buffer = rdr.ReadLine()) != null)
                                {
                                    //buffer = rdr.ReadLine();
                                    Console.WriteLine(buffer);
                                }
                            }
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }
            }
            //Console.ReadKey();
        }
        

    }
}
