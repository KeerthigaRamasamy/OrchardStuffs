using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread_sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread running!!!");

            //creating a delegate of the child threads using threadstart class

            ThreadStart t1 = new ThreadStart(thread.child_thread1);
            ThreadStart t2 = new ThreadStart(thread.child_thread2);

            //creating the thread class objects to start the child threads
            Thread th1 = new Thread(t1);
            Thread th2 = new Thread(t2);

            //starting child thread 1        
            th1.Start();
            //starting child thread 2
            th2.Start();
   
            Console.ReadKey();
        }
    }
    public class thread
    {
        public static void child_thread1()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Hello I'm thread1"+" "+i);
                    //making the thread to sleep for 1s so that child thread2 can execute
                    Thread.Sleep(1000);
            }
        }
        public static void child_thread2()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Hello I'm thread2" + " " + i);

                //making the thread to sleep for 1s so that child thread1 can execute
                Thread.Sleep(1000);
            }
        }
    }
}
