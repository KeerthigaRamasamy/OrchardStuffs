using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_manangement
{
    public partial class application_state : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //creating the Application state variable, set the timeout for 1min

            Application["app_var1"] = TextBox1.Text;
            Application["app_var2"] = TextBox2.Text;
            //query string
            Response.Redirect("application_state2.aspx?userid=" + TextBox1.Text + "&email=" + TextBox2.Text);
        }
    }
}