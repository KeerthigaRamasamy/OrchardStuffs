using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace authentication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter("Select* from employee", c);
            DataSet s = new DataSet();
            adap.Fill(s, "employee");
            Repeater1.DataSource = s;
            Repeater1.DataBind();
        }
    }
}