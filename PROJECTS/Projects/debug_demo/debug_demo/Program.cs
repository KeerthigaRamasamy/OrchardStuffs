using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace debug_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Debugging................");
            Debug.Assert(false, "debug assert runs");
        }
    }
}
