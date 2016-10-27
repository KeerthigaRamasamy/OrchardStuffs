using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace trace
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter("SELECT* FROM employee",con);
            DataSet s = new DataSet();
            adap.Fill(s, "Employee");
            GridView1.DataSource = s;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}