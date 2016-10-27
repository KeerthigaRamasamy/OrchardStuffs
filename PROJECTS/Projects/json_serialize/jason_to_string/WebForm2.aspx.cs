using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using employee;

namespace jason_to_string
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<employee_details> emp_list = new List<employee_details>();
            string s = "[{\"id\":1,\"name\":\"Keerthi\",\"age\":21},{\"id\":2,\"name\":\"Karthik\",\"age\":22}]";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            emp_list= (List<employee_details>) serializer.Deserialize(s, typeof(List<employee_details>));

            foreach(employee_details d in emp_list)
            {
                Response.Write("Id="+" "+d.id+"</br>");
                Response.Write("name="+" "+d.name+ "</br>");
                Response.Write("age="+" "+d.age + "</br>");
            }
        }
    }
}