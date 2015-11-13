using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
    [TestFixture]
    public class Collections
    {
	    [Test]
	    public void ArrayBasics()
	    {
		    int[] array = new int[5];
		    array[0] = 10;
		    int value = array[0];
            Assert.AreEqual(10, value);

            Assert.AreEqual(5, array.Length);

		    for (int i = 0; i < array.Length; i++)
		    {
			    Console.WriteLine("{0}: {1} ", i, array[i]);
		    }

		    foreach (int tmp in array)
		    {
                Console.WriteLine(tmp);   
		    }

		    IEnumerable<int> sequence = array;
            foreach (int tmp in sequence)
            {
                Console.WriteLine(tmp);

            }

	    }
    }
}
