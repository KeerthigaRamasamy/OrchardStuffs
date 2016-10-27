using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{

    //static and this keyword are the two keywords that need to be added for an extension method
    static class extension
    {

        //this keyword should preceed the type we are extending
        public static string[] split_into_two(this string s)
        {
            //int l = s.Length;
            //int m = l / 2;
            char c = '$';
            string[] s1= s.Split(c);
            return s1;
        }
    }
}
