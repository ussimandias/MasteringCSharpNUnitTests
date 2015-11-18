using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public class StartAndStopper
    {
        public void StartAndStopp(IControllable controllable)
        {
            controllable.Start();
            controllable.Stop();
        }
    }
}
