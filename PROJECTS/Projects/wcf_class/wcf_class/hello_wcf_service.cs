using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_class
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "hello_wcf_service" in both code and config file together.
    public class hello_wcf_service : Ihello_wcf_service
    {
        public string DoWork(string name)
        {
            return ("Hello" + name);
        }
    }
}
