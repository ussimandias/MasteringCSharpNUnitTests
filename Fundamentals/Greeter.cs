using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Greeter
    {
	    
	    public Greeter(string speaker )
	    {
            this.Speaker = speaker;
	    }

        //private string _speaker;
	    public string Speaker{ get ; private set ; }

	    public string SayHello()
	    {
		    return "Hello";
	    }

        public string SayHello(string recipient)
        {
	        if (Speaker == null)
	        {
		        return "Hello" + recipient;
	        }
            return "Hello " + recipient + " from " + Speaker;
        }

        public string SayHello2(string recipient)
        {
	        if (recipient == null)
	        {
		        throw new ArgumentNullException("recipient");
	        }
            if (Speaker == null)
            {
                return "Hello" + recipient;
            }
            return "Hello " + recipient + " from " + Speaker;
        }
    }
}
