using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading
{
    class thread_sleep
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------Multi Threading------------");
            Console.WriteLine("Main thread is executing!!!!");
            Console.WriteLine();
            Console.WriteLine("Creating the thread start object for the child thread");

            //creating object of the thread start class to assign the function as child thread
            ThreadStart child = new ThreadStart(child_thread);

            //creating the object of thread class
            Thread th = new Thread(child);
            th.Start();         //starting the child thread
            Console.WriteLine("Main Thread paused for 2 seconds");
            Thread.Sleep(2000);
            Console.WriteLine("Main thread resumes");
            //th.Abort();
            Console.ReadKey();
        }
        public static void child_thread()
        {
            Console.WriteLine("Child thread started executing!!!");
            Console.WriteLine();
            Console.WriteLine("Thread paused for 5 seconds");
            Thread.Sleep(5000);
            Console.WriteLine("Child thread resumes");
            Console.WriteLine("Child thread completed");
        }
    }
}
