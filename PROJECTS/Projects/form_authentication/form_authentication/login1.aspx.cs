using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace form_authentication
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
           if(FormsAuthentication.Authenticate(TextBox1.Text,TextBox2.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                //Response.Redirect("Main_form.aspx");
            }
           else
            {
               Label3.Text = "Invalid user name or password";
            }
           
        }
    }
}