using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class Class1
    {
        public void fun()
        {
            LMSJuly2016Entities context = new LMSJuly2016Entities();
            context.sp_Insert_BookDetails1("title", "JK Rowling", "writes on fiction", "Fiction", "first", "xyz", 5);
        }
    }
}
