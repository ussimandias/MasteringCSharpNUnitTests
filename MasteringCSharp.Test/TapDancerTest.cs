using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    [TestFixture]
    public class TapDancerTest
    {
        [Test]
        public void NameDefaults()
        {
            Dancer dancer = new TapDancer();
            Assert.AreEqual("My Tap Dancer", dancer.Name);
        }

        [Test]
        public void DanceBabyDance()
        {
            Dancer dancer = new TapDancer();
            dancer.Dance();
        }

        [Test]
        public void DanceTwice()
        {
            Dancer dancer = new TapDancer();
            dancer.DanceTwice();
        }
    }
}
