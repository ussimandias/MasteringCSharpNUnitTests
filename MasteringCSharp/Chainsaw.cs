using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public sealed class Chainsaw : IControllable
    {
        public void Start()
        {
            Console.WriteLine("Vrrmmmm...");
        }

        public void Stop()
        {
            Console.WriteLine("gRRrrhhh...");
        }
    }
}
