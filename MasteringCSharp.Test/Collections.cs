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

        [Test]
        public void ListBasics()
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            Assert.AreEqual("Fred", names[0]);
        }

        [Test]
        public void Generics()
        {
            Fred<string> fred = new Fred<string>("Hi");
            Assert.AreEqual("Hi", fred.Foo() );

            Fred<int> fred2 = new Fred<int>(100);
            Assert.AreEqual(100, fred2.Foo());
        }

        public class Fred<T>
        {
            T _greeting;

            public Fred(T greeting)
            {
                this._greeting = greeting;
            }

            public T Foo()
            {
                return _greeting;
            }  
        }
    }
}
