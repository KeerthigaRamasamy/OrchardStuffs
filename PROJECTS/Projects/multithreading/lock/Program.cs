using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace @lock
{
    class Program
    {
        public static long total = 0;
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("-----InterLock and Lock in Multithreading------");
            //multithread obj = new multithread();

            //assigning three threads to the same function
            Thread t1 = new Thread(fun);
            Thread t2 = new Thread(fun);
            Thread t3 = new Thread(fun);
            //start executing the thread
            while (true)
            {
                Console.WriteLine("1.execute the thread");
                Console.WriteLine("2.exit");
                while (!(int.TryParse(Console.ReadLine(), out c)) || c > 3 || c < 0)
                {
                    Console.WriteLine("Enter 1 or 2");
                }
                if (c == 1)
                {
                    try
                    {
                        t1.Start();
                        t2.Start();
                        t3.Start();
                        Console.WriteLine(total);
                    }
                    catch (ThreadAbortException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (ThreadStartException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (ThreadStateException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (c == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
        static public void fun()
        {
            for (int i = 1; i < 1000000; i++)
            {
                total++;
            }
        }
    }
}
//    public class multithread
//    {
//        public long total;
//        //object _lock = new object();
//        public multithread()
//        {
//            total = 1;
//        }
//        public void fn()
//        {
//            for (int i = 1; i < 1000000; i++)
//            {
//                total++;
//            }
//            //for (int i = 1; i < 1000000; i++)
//            //{
//            //    lock (_lock)
//            //    {
//            //        total++;
//            //    }
//            //}
//            //for (int i = 1; i < 1000000; i++)
//            //{
//            //    Interlocked.Increment(ref total);
//            //}
//        }
//    }
//}
