using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TinhHieu
    {
        static void Main(string[] args)
        {
        }
        private readonly int[] number;
        public TinhHieu() 
        {
            number = new[] {10, 9, 8, 7 } ;
        }
        [Test]
        public void TinhHieu_Test() 
        {
            int TinhHieu = number[0] - number[1] - number[2] - number[3];
            Assert.That(TinhHieu, Is.EqualTo(-14));
        }
    }
}
