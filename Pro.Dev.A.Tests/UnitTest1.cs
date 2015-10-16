using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pro.Dev.A.Rest;

namespace Pro.Dev.A.Tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        ValuesController1 con;

        [TestInitialize]
        public void Setup()
        {
            con = new ValuesController1();
        }
    
        [TestMethod]
        public void SendJson_Success()
        {
            EmailModel email = new EmailModel();

            email.To = "me@foo.com";
            email.Subject = "me@foo.com";
            email.Message = "me@foo.com";
            email.DeliveryType = "me@foo.com";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SendJson_Null()
        {
            EmailModel email = new EmailModel();

            email.To = null;
            email.Subject = null;   
            email.Message = "me@foo.com";
            email.DeliveryType = "me@foo.com";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SendJson_StringEmpty()
        {
            EmailModel email = new EmailModel();

            email.To = string.Empty;
            email.Subject = string.Empty;
            email.Message = "me@foo.com";
            email.DeliveryType = "me@foo.com";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SendJson_vaildEmailAddressTo()
        {
            EmailModel email = new EmailModel();

            email.To = "sdfsdfsdf";
            email.Subject = "sdfsdf";
            email.Message = "me@foo.com";
            email.DeliveryType = "me@foo.com";

            con.Submit(email);
        }

    }
}
