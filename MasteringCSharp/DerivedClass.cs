using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("derived default")
        {          
        }

        public DerivedClass(string localName) 
            : base("derived " + localName)
        {          
        }

        public override int CalculateResult(int x)
        {
            return x/2;
        }

        public int QuadripleInput(int x)
        {
            return x * 4;
        }
    }
}
