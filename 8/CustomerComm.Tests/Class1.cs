using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCommLib;
using Moq;
using Assert = NUnit.Framework.Assert;

namespace CustomerCommm.Tests
{
    [TestFixture]
    public class Class1
    {
        public IMailSender mailsender { get; set; }
        [OneTimeSetUp]
        public void Init()
        {
            mailsender = new MailSender();
        }

        [TestCase]
        public void Test()
        {
            var mockRepo = new Mock<CustomerComm>(mailsender);
            mockRepo.Setup(x => x.SendMailToCustomer()).Returns(true);
            Assert.That(mockRepo.Object.SendMailToCustomer(), Is.EqualTo(true));
        }
    }
}
