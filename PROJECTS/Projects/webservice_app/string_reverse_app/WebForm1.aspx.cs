using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace string_reverse_app
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str=TextBox1.Text;
            localhost.WebService1 obj = new localhost.WebService1();
            string str1=obj.StringReverseMethod(str);
            TextBox2.Text = str1;
        }
    }
}