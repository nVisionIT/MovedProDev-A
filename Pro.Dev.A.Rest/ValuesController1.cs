using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using SendGrid;

namespace Pro.Dev.A.Rest
{
    public class ValuesController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        public void Submit(EmailModel email)
        {
             
            if (string.IsNullOrEmpty(email.To) || string.IsNullOrEmpty(email.Subject))
            {
                throw new Exception("Data is not correct");
            }

            MailAddress mail = new MailAddress(email.To);

            if (email.DeliveryType != "Email")
            {
                throw new Exception("Delivery Type not set to type,  Email.");
            }
        }
    }
}