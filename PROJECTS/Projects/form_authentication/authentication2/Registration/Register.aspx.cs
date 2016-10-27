using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

namespace authentication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con=new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True"))
            {
                string s1 =TextBox1.Text;
                string s2 = TextBox2.Text;
                string s5 = TextBox3.Text;
                if(!(s2==s5))
                {
                    Label1.Visible = true;
                    Label1.Text = "password mismatch";
                    TextBox2.Text = null;
                    TextBox3.Text = null;
                    return;
                }
                int return_code;
                string s4 = FormsAuthentication.HashPasswordForStoringInConfigFile(s2, "SHA1");
                SqlCommand com = new SqlCommand("sp_insert_tbl_users",con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@username", s1);
                SqlParameter p2 = new SqlParameter("@pass_word", s4);    
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
               
                con.Open();
                return_code = (int)com.ExecuteNonQuery();
                if(return_code==-1 )
                {
                    Label1.Visible = true;
                    Label1.Text = "username already exists";
                    TextBox1.Text = null;
                    return;
                }
                else
                {
                    Response.Redirect("~/login1.aspx");
                }
            }
        }
    }
}