using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_manangement
{
    public partial class session_state2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["session_var1"].ToString();
            TextBox2.Text = Session["session_var2"].ToString();
        }
    }
}