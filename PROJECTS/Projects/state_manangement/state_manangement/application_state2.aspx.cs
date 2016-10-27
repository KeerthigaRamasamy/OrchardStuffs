using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_manangement
{
    public partial class application_state2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application["app_var1"].ToString();
            Label2.Text = Application["app_var2"].ToString();
        }
    }
}