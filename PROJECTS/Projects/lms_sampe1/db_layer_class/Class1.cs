using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


//CRUD operations 
namespace db_layer_class
{
    public class Class1
    {
        //creating object of db context to access the database
        // LMSJuly2016Entities2 context = new LMSJuly2016Entities2();
        public static void fun()
        {
            LMSJuly2016Entities3 context = new LMSJuly2016Entities3();
             
        }
    }
}
