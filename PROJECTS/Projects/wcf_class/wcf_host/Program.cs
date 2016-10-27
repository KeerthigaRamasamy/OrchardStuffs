using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using wcf_class;

namespace wcf_host
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Uri baseaddress = new Uri("http://localhost:8000/ServiceModelSamples/Service");

            ////
            //ServiceHost self_host = new ServiceHost(typeof(hello_wcf_service),baseaddress);

            ////
            //self_host.AddServiceEndpoint(typeof(Ihello_wcf_service), new WSHttpBinding(),"hello_wcf_service");

            //ServiceMetadataBehavior mb = new ServiceMetadataBehavior();
            //mb.HttpGetEnabled = true;
            //self_host.Description.Behaviors.Add(mb);

            //self_host.Open();
            //Console.WriteLine("Service hosted successfully");
            //self_host.Close();
            using (ServiceHost host = new ServiceHost(typeof(wcf_class.hello_wcf_service)))
            {
                host.Open();
                Console.WriteLine("Host opened successfully");
            }
            Console.ReadKey();
        }
    }
}
