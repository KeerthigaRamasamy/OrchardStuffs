using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace dal
{
    public class Class1
    {
        public void fun()
        {
            LMSJuly2016Entities context = new LMSJuly2016Entities();
            SqlParameter p1 = new SqlParameter("@Author1", "Author1");
            SqlParameter p2 = new SqlParameter("@AuthorDesc", "AuthorDesc");
            //context.sp_Insert_Authors ("author1","author1desc");
            //context.Insert_BookDetails1("title", "JK Rowling", "writes on fiction", "fiction", "1st", "xyz", 5);
            context.Database.ExecuteSqlCommand("sp_Insert_Authors", p1, p2);
            //context.sp_Insert_BookDetails1("title", "JK Rowling", "writes on fiction", "fiction", "1st", "xyz", 5);
        }
    }
}
