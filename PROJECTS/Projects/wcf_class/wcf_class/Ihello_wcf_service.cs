using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


//automatically generated interface for wcf with one more class implementing the interface
namespace wcf_class
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ihello_wcf_service" in both code and config file together.

        //service contract attribute tells that the following interface is going to be a wcf service
    [ServiceContract]
    public interface Ihello_wcf_service
    {

        //OperationContract attribute specifies that the method is exposed to the clients who are invoking this service
        [OperationContract]
         string DoWork(string name);
    }
}
