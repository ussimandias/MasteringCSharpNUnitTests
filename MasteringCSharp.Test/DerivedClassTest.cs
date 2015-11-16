using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    /*
     * Note:
     * The DerivedClass (in the case the 'Derived' class) 
     * instance still has the state 
     * of BaseClass (in the case the 'Base' class)
     */

    [TestFixture]
    class DerivedClassTest
    {
        [Test]
        public void DefaultName()
        {
            /*DerivedClass test = new DerivedClass();
             * 
             * If an instance of the DerivedClass object is created line(23)
             * Intellisense will only provide the methods, objects
             * declared in this class (QuadripleInput())
            */

            BaseClass test = new DerivedClass();
            Assert.AreEqual("derived default", test.Name);
        }

        [Test]
        public void SpecifiedName()
        {
            BaseClass test = new DerivedClass("Smith");
            Assert.AreEqual("derived Smith", test.Name);
        }

        [Test]
        public void QuadripleInputQuadriplesInput()
        {
            DerivedClass test = new DerivedClass();
            Assert.AreEqual(20, test.QuadripleInput(5));
        }

        [Test]
        public void TrebleInput()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(9, test.TrebleInput(3));
        }

        [Test]
        public void CalculateResultHalvesInput()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(4, test.CalculateResult(8));
        }
    }
}
