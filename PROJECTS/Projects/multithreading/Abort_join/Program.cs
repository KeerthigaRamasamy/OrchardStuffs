using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Abort_join
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Thread start,abort,join sample----");
            ThreadStart t = new ThreadStart(child_thread);
            Thread th = new Thread(t);
            Console.WriteLine("In main starting the child thread");
            th.Start();
            Thread.Sleep(2000);
            //sleep main thread so that the child thread executes
            Console.WriteLine("Aborting the child thread in the main function");
            try
            {
                //thread abort(stopping from executing)
                th.Abort();
                //join stops the current thread and finishes executing the child thread to join with the main thread
                th.Join();
                Console.WriteLine("the child thread completed executing");
                //after thread abortion can't start the thread, throws exception
                th.Start();
            }
            catch(ThreadStateException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
        public static void child_thread()
        {
            for(int i = 0;i<10;i++)
            Console.WriteLine("Child thread executing!!!");
        }
    }
}
