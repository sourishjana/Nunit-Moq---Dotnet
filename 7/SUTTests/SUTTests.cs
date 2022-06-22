using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using System.Collections;

namespace SUTTests
{
    [TestFixture]
    [Category("Math")]
    [Author("Sourish Kumar Jana", "sourish@gmail.com")]
    public class SUTTests
    {
        [Test]
        public void Test1()
        {
            Calculator c = new Calculator();
            Assert.Throws<DivideByZeroException>(() => c.Divide(3, 0));
        }
    }
}
