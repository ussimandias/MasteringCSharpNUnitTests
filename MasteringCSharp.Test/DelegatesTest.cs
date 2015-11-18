using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleMethodInterface()
        {
         IInt32Action action = new Delegates();   
            action .DoIt(10);
        }

        [Test]
        public void SingleDelegateMethodFromMethod()
        {
            Delegates target = new Delegates("John");
            Int32Action action = new Int32Action(target.RandomRob);

            action.Invoke(5);
            action(6);
        }

        [Test]
        public void DelegateFromSaticMethod()
        {
            Delegates target = new Delegates();
            Int32Action action = new Int32Action(Delegates.StaticRob);

            action.Invoke(7);
        }


        [Test]
        public void MultiCast()
        {           
            Int32Action action1 = new Int32Action(Delegates.StaticRob);
            Int32Action action2 = new Int32Action(Delegates.StaticRob2);

            Int32Action action3 = action1 + action2;
            action3(20);
        }
    }
}
