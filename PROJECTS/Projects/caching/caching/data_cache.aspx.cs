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
    public partial class data_cache : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            TextBox1.Text = start.ToString();
            //System.Text.StringBuilder
           
            if (Cache["cache_var"] != null)
            {
                GridView1.DataSource = Cache["cache_var"];
                //GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("SELECT* FROM tbl_products", c);
                DataSet ds = new DataSet();
                //filling the dataset which
                ad.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Cache["cache_var"] = ds;
            }
            DateTime end = DateTime.Now;
            TextBox2.Text = end.ToString();
            int timediff = (start - end).Seconds;
            TextBox3.Text = timediff.ToString();
           
        }
    }
}