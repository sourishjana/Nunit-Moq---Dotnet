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
            Assert.That(e.GetEmployees(), Is.All.Not.Null);
        }

        [Test]
        public void Test2()
        {
            EmployeeManager e = new EmployeeManager();
            Assert.That(e.GetEmployees().Any(p => p.EmpId == 100));
        }

        [Test]
        public void Test3()
        {
            EmployeeManager e = new EmployeeManager();
            CollectionAssert.AllItemsAreUnique(e.GetEmployees());
        }

        [Test]
        public void Test4()
        {
            EmployeeManager e = new EmployeeManager();
            CollectionAssert.AreEqual(e.GetEmployees(),e.GetEmployeesWhoJoinedInPreviousYears());
        }
    }
}
