using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    [TestFixture]
    internal class TimSoChiaHetCho2
    {
        static void Main(string[] args)
        {
        }
        [TestCaseSource(nameof(TestData))]
        public void TimSoChiaHetCho2_Test(int number)
        {
            Assert.That(number % 2, Is.EqualTo(0), $"Số {number} không chia hết cho 2");
        }

        private static IEnumerable<int> TestData => new List<int> { 0, 4, 5, 6, 18, 10, 9, 21, 25, 40 };
    }
}
