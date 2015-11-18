using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    [TestFixture]
    public class StartAndStopTest
    {
        [Test]
        public void StartAndStop()
        {
            Dancer dancer = new TapDancer();
            Chainsaw chainsaw = new Chainsaw();

            StartAndStopper test = new StartAndStopper();
            test.StartAndStopp(dancer);
            test.StartAndStopp(chainsaw);
        }
    }
}
