using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Reading and Writing into files */
namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream s = new FileStream("py.txt",FileMode.OpenOrCreate, FileAccess.Read,FileShare.ReadWrite); //creating a file stream object and defining attributes
            Console.WriteLine("Reading the file series.txt");

            /* Writing the data into the file */

            Console.WriteLine("Writing the text to file py.txt");
            try
            {
                if (File.Exists("py.txt"))                //if file exists
                {
                    string line1;
                    Console.WriteLine("Enter the text to be written into the file");
                    line1 = Console.ReadLine();
                    File.WriteAllText("py.txt", line1);   //writing the string to the file
                }
                else
                {
                    Console.WriteLine("The file doesn't exist");
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file doesn't exist");
            }

            /* Reading the data from the file */
            try
            {
                if (File.Exists("py.txt"))                 //if file exists
                {
                    string line;
                    line = File.ReadAllText("py.txt");    //reading the file
                    Console.WriteLine(line);              //printing the readed text
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file doesn't exist");
            }

            StreamReader rd = new StreamReader("C:/py.text");   //creating an object of stream reader class
            Console.WriteLine("Using stream reader to print each line in the file");
            try
            {
                while (rd.ReadLine() != null)                //checks if the line ends
                {
                    string l;
                    l = rd.ReadLine();
                    Console.WriteLine(l);
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file doesn't exist");
            }

            /* Deleting a file */
            try
            {
                if (File.Exists("py.txt"))
                {
                    File.Delete("py.txt");
                    Console.WriteLine("file deleted");
                }
                else
                {
                    Console.WriteLine("file doesn't exist");
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file doesn't exist");
            }
            Console.ReadKey();
        }
    }
}
