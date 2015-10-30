using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using Pro.Dev.A.Rest;

namespace Pro.Dev.A.Rest2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public EmailModel Get(int id)
        {
            return new EmailModel()
            {
                To = "",
                DeliveryType = "email",
                Message = "Hello",
                Subject = "stuff"
            };
        }
        
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        [HttpPost]
        public HttpResponseMessage SendEmail(EmailModel email)
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

            return base.Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}