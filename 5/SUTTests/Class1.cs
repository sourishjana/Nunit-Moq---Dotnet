using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeapYearCalculatorLib;

namespace SUTTests
{
    [TestFixture]
    public class Class1
    {
        [TestCaseSource("LeapYearCalculatorTestData")]
        public void Test1(int year, int res)
        {
            LeapYearCalculator c = new LeapYearCalculator();
            Assert.That(c.IsLeapYear(year), Is.EqualTo(res));
        }
        private static IEnumerable<TestCaseData> LeapYearCalculatorTestData
        {
            get
            {
                yield return new TestCaseData(2016, 1);
                yield return new TestCaseData(1999, 0);
                yield return new TestCaseData(1752, -1);
                yield return new TestCaseData(10000, -1);
                yield return new TestCaseData(1753, 0);
                yield return new TestCaseData(9999, 0);
            }
        }
    }
}
