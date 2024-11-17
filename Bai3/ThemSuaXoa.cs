using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class ThemSuaXoa
    {
        static void Main(string[] args)
        {
        }
        public class XeOTo
        {
            public int Ma { get; set; }
            public string Ten { get; set; }
            public decimal Gia { get; set; }
            public string GhiChu { get; set; }
        }

        [TestFixture]
        public class XeOToTests
        {
            private List<XeOTo> _data;

            [SetUp]
            public void SetUp()
            {
                _data = new List<XeOTo>
        {
            new XeOTo { Ma = 1, Ten = "Toyota", Gia = 50000, GhiChu = "Xe mới" },
            new XeOTo { Ma = 2, Ten = "Honda", Gia = 45000, GhiChu = "Xe đã qua sử dụng" }
        };
            }

            [Test]
            public void TestAddXeOTo()
            {
                var newXe = new XeOTo { Ma = 3, Ten = "Mazda", Gia = 60000, GhiChu = "Xe sang" };
                _data.Add(newXe);
                Assert.That(_data.Count, Is.EqualTo(3));
            }

            [Test]
            public void TestUpdateXeOTo()
            {
                var xe = _data.Find(x => x.Ma == 1);
                xe.Gia = 52000;
                Assert.That(xe.Gia, Is.EqualTo(52000));
            }

            [Test]
            public void TestDeleteXeOTo()
            {
                var xe = _data.Find(x => x.Ma == 2);
                _data.Remove(xe);
                Assert.That(_data.Count, Is.EqualTo(1));
            }
        }
    }
}
