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
        public void Send_Success()
        {
            EmailModel email = new EmailModel();

            email.To = "me@foo.com";
            email.Subject = "me@foo.com";
            email.Message = "me@foo.com";
            email.DeliveryType = "Email";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Send_Null()
        {
            EmailModel email = new EmailModel();

            email.To = null;
            email.Subject = null;   
            email.Message = "me@foo.com";
            email.DeliveryType = "Email";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Send_StringEmpty()
        {
            EmailModel email = new EmailModel();

            email.To = string.Empty;
            email.Subject = string.Empty;
            email.Message = "me@foo.com";
            email.DeliveryType = "Email";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void Send_InvalidEmailAddressException()
        {
            EmailModel email = new EmailModel();

            email.To = "sdfsdfsdf";
            email.Subject = "sdfsdf";
            email.Message = "me@foo.com";
            email.DeliveryType = "Email";

            con.Submit(email);
        }

        [TestMethod]
        public void Send_ValidEmailAddressTo()
        {
            EmailModel email = new EmailModel();

            email.To = "test@mail.com";
            email.Subject = "sdfsdf";
            email.Message = "me@foo.com";
            email.DeliveryType = "Email";

            con.Submit(email);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Send_DeliveryTypeCheckNotEmail()
        {
            EmailModel email = new EmailModel();

            email.To = "test@mail.com";
            email.Subject = "Test";
            email.Message = "me@foo.com";
            email.DeliveryType = "Post";

            con.Submit(email);
        }

        //[TestMethod]
        //public void SendGrid_Send()
        //{
        //    EmailModel email = new EmailModel();

        //    email.To = "test@mail.com";
        //    email.Subject = "sdfsdf";
        //    email.Message = "me@foo.com";
        //    email.DeliveryType = "Email";

        //}

    }
}
