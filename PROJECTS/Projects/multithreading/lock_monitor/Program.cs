using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lock_monitor
{
    class Program
    {
        public static object _lock = new object();
        public static object _o = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Sample lock and monitor for thread synchronization");
            Console.WriteLine("In main ,starting the child thread");
            ThreadStart ts1 = new ThreadStart(child);
            ThreadStart ts2 = new ThreadStart(child);
            Thread th1 = new Thread(ts1);
            Thread th2 = new Thread(ts2);
            th1.Start();
            th2.Start();
            Console.ReadKey();
        }

        //child thread
        public static void child()
        {
            Console.WriteLine("Child thread executing");
            //using lock
            //locking this section
            //lock (_lock)
            //{

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Thread.Sleep(2000);
            //        Console.WriteLine(i);
            //    }
            //}

            //using monitor      
            Monitor.Enter(_o);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(i);
                }
            }
            finally
            {
                Monitor.Exit(_o);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine(i);
            //}
        }
    }
}
