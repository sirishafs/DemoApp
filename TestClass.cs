using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;
            Assert.AreEqual(x, y);
        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("This is an error, Error");
        }

        [Test]
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();
        }
    }
}
