using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi1.Models;
using DAL1;
using System.Configuration;


namespace webapi1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values 
       [HttpGet]
        public IEnumerable<employee> Get()
        {
            using (M1037727Entities dbcontext=new M1037727Entities())
            {
                return dbcontext.employees.ToList();

            }
        }
        [HttpGet]
        // GET api/values/5
        public employee Get(int id)
        {
            using (M1037727Entities dbcontext = new M1037727Entities())
            {
                return dbcontext.employees.FirstOrDefault(e => e.id == id);
            }
       
        }


        [HttpPost]
        // POST api/values
        //public void Post(string name1, int age1,string location1)
        public void Post([FromBody]employee e1)
        {
            using (M1037727Entities dbcontext = new M1037727Entities())
            {
                
                dbcontext.sp_insert_employees(e1.name, e1.age, e1.location);
            }
            
        }


        [HttpPut]
        // PUT api/values/5
        public void Put([FromBody]employee e1)
        {
            using (M1037727Entities dbcontext = new M1037727Entities())
            {              
                dbcontext.sp_Update_employees(e1.id, e1.name, e1.age, e1.location);               
            }
       }



        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id4)
        {
            using (M1037727Entities dbcontext = new M1037727Entities())
            {      
                dbcontext.sp_Delete_employees(id4);
            }
        }
    }
}
