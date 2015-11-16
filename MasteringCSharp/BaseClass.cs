using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public class BaseClass
    {
        private readonly string _name;

        public string Name { get { return _name; } }
        
        public BaseClass() : this("default")
        {
            
        }

        public BaseClass( string name)
        {
            this._name = name;
        }

        public virtual int CalculateResult(int x)
        {
            return x * 2;
        }

        public virtual int TrebleInput(int x)
        {
            return x * 3;
        }
    }
}
