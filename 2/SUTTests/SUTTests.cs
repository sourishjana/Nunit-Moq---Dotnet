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
        [TestCaseSource(typeof(AddCases))]
        [Order(1)]
        public void Test1(int firstNo,int secondNo)
        {
            Calculator c = new Calculator();
            Assert.That(c.Add(firstNo,secondNo),Is.EqualTo(firstNo+secondNo));
        }

        [TestCaseSource(typeof(AddCases))]
        [Order(4)]
        public void Test2(int firstNo, int secondNo)
        {
            Calculator c = new Calculator();
            Assert.That(c.Subtract(firstNo, secondNo), Is.EqualTo(firstNo - secondNo));
        }

        [TestCaseSource(typeof(AddCases))]
        [Order(3)]
        public void Test3(int firstNo, int secondNo)
        {
            Calculator c = new Calculator();
            Assert.That(c.Multiply(firstNo, secondNo), Is.EqualTo(firstNo * secondNo));
        }

        [TestCaseSource(typeof(AddCases))]
        [Ignore("Ignore Divide Test")]
        [Order(2)]
        public void Test4(int firstNo, int secondNo)
        {
            Calculator c = new Calculator();
            Assert.That(c.Divide(firstNo, secondNo), Is.EqualTo(firstNo / secondNo));
        }
    }
}


class AddCases : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return new Object[] { 1, 1 };
        yield return new Object[] { 5, 50 };
        yield return new Object[] { 55, 66 };
    }
}