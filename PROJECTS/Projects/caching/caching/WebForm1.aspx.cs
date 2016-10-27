using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace caching
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
             SqlDataAdapter ad = new SqlDataAdapter("SELECT* FROM tbl_products", c);
             DataSet ds = new DataSet();
                //filling the dataset which
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label3.Text = (DateTime.Now).ToString();
        }
    }
}