using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

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
            if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                //Response.Redirect("Main_form.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid user name or password";
            }
            //if(FormAuthenticate(TextBox1.Text,TextBox2.Text))
            //{
            //    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text,false);
            //    Response.Redirect("Main_form.aspx");
            //}
            //else
            //{
            //    Label3.Visible = true;
            //    Label3.Text = "Incorrect Username or Passoword";
            //    TextBox1.Text = null;
            //    TextBox2.Text = null;
            //}

        }
        private bool FormAuthenticate(string s1,string s2)
        {
            using (SqlConnection con = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True"))
            {
                //string s1 = TextBox1.Text;
                //string s2 = TextBox2.Text;
                string s4 = FormsAuthentication.HashPasswordForStoringInConfigFile(s2, "SHA1");
                int return_code;
                SqlCommand com = new SqlCommand("spAuthenticateUser", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@username", s1);
                SqlParameter p2 = new SqlParameter("@pass_word", s4);
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                con.Open();
                return_code = (int)com.ExecuteScalar();
                //return_code = (int)com.ExecuteNonQuery();
                if (return_code == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                    //Response.Redirect("~/Main_form.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration/Register.aspx");
        }
    }
}