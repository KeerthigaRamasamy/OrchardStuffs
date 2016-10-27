using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jquery
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue=="Aqua")
            {

            }
            if(DropDownList1.SelectedValue=="Light green")
            {

            }
            if(DropDownList1.SelectedValue=="Light cyan")
            {

            }
        }
    }
}