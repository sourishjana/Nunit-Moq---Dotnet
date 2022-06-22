using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsLib;

namespace SUTTests
{
    [TestFixture]
    public class SUTTest
    {
        [Test]
        public void Test1()
        {
            EmployeeManager e = new EmployeeManager();
            Assert.That(e.HeadCount, Is.EqualTo(0));
            e.AddEmployee(new Employee() { Id = 1, Name = "Sourish" });
            Assert.That(e.HeadCount, Is.EqualTo(1));
        }
    }
}
