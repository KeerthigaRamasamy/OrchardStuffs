using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_manangement
{
    public partial class View_form2 : System.Web.UI.Page
    {
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                TextBox1.Text = 0.ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //assigning the count value to View state variable
            if (ViewState["view_var"] != null)
            {
                count = (int)ViewState["view_var"]+ 1;
            }
            TextBox1.Text = count.ToString();
            ViewState["view_var"] = count;
        }
    }
}