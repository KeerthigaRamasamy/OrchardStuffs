using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using employee;
using System.Web.Script.Serialization;


//parsing jason object to string and vice versa
namespace jason_to_string
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            employee_details e1 = new employee_details{ id = 1, name = "Keerthi", age = 21 };
            employee_details e2 = new employee_details { id = 2, name = "Karthik", age = 22 };
            employee_details e3 = new employee_details { id = 3, name = "pooja", age = 21 };

            List<employee_details> emp_list = new List<employee_details>();
            emp_list.Add(e1);
            emp_list.Add(e2);

            //serailizing c# object to jason object
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jason= serializer.Serialize(emp_list);
            Response.Write(jason);
        }
    }
}