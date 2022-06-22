using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace SUTTests
{
    [TestFixture]
    public class SUTTests
    {
        [Test]
        public void UnitUnderTest_Scenario_ExpectedOutcome1()
        {
            Calculator c = new Calculator();
            Assert.That(c.Add(10,25),Is.EqualTo(35));
        }
        [Test]
        public void UnitUnderTest_Scenario_ExpectedOutcome2()
        {
            Calculator c = new Calculator();
            Assert.That(c.Add(10, -25), Is.EqualTo(0));
        }
    }
}
