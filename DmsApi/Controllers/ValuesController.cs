using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using DmsBusiness;

namespace DmsApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Contact> Get()//string[] Get()
        //public string[] Get()
        {
            //return  "Hello World to Api";
            return GetAllContacts();
            //return contact();
            // return new string[] { "value1", "value2" };
        }

        private string[] contact()
        {

            return new string[] { "value1", "value2" };
        }

        private IEnumerable<Contact> GetAllContacts()
        {
            return new List<Contact>
            {
                new Contact
                {
                    Id = 1,
                    Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Dan Roth"
                }
            };
        }

        public class Contact
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Dms Api";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
