using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    [TestFixture]
    class BaseClassTest
    {
        [Test]
        public void CalculateResultDoublesInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(4, test.CalculateResult(2));
        }

        [Test]
        public void TrebleInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(9, test.TrebleInput(3));
        }

        [Test]
        public void NameDefaultsToDefault()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual("default", test.Name);
        }

        [Test]
        public void SpecifiedNameIsPropergated()
        {
            BaseClass test = new BaseClass("Smith");
            Assert.AreEqual("Smith", test.Name);
        }
    }
}
