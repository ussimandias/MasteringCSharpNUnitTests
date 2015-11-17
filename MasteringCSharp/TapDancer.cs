using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public class TapDancer : Dancer
    {
        public TapDancer() : base("My Tap Dancer")
        {
            
        }
        public override void Dance()
        {
            Console.WriteLine("BreaK Dancing");
        }
    }
}
