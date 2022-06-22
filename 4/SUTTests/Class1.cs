using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace SUTTests
{
    [TestFixture]
    public class Class1
    {
        [TestCaseSource("ComparetwoNumbersTestData")]
        public void Test1(int firstNo, int secondNo,int thirdNo)
        {
            MathLib c = new MathLib();
            Assert.That(c.CompareTwoNumbers(firstNo, secondNo), Is.EqualTo(thirdNo));
        }
        private static IEnumerable<TestCaseData> ComparetwoNumbersTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, 0);
                yield return new TestCaseData(1, 2, -1);
                yield return new TestCaseData(2, 1, 1);
            }
        }
    }
}


