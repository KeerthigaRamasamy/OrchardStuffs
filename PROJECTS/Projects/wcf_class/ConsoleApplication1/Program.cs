using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(wcf_class.hello_wcf_service)))
            {
                host.Open();
                Console.WriteLine("Host opened successfully");
                Console.ReadKey();
            }
        }
    }
}
