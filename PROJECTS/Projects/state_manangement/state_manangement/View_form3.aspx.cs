using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_manangement
{
    public partial class View_form3 : System.Web.UI.Page
    {
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!(IsPostBack))
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32( TextBox1.Text);
            TextBox1.Text = (count+1).ToString();
        }
    }
}