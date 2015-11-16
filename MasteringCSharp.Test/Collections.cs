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

            Assert.AreEqual(1, names.Count);
            names.Add("Petr");
            Assert.AreEqual(2, names.Count);

            names.RemoveAt(0);
            Assert.AreEqual(1, names.Count);
            Assert.AreEqual("Petr", names[0]);

            names[0] = "Paula";
            Assert.AreEqual("Paula", names[0]);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            /*
             * var integers = new  List<int>(50){10, 20};
             * is
             * Equivalent to:
             */

            var tmp = new List<int>(50);
            tmp.Add(10);
            tmp.Add(20);
            var integers = tmp;

            integers = new List<int>{integers.Count};
            Assert.AreEqual(2, integers[0]);
        }

        [Test]
        public void DictionaryBasics()
        {
            var map = new Dictionary<string, int>();
            map.Add("MGS V", 1);
            map["BattleFront"] = 2;

            //foreach (var entry in map)
            //{
            //    Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            //}

            /*
             * Use this if your sure there is a value...
             * int Value = map["MGS V"];
             * 
             */

            int Value;
            bool KeyFound = map.TryGetValue("BattleFront", out Value);
            Assert.IsTrue(KeyFound);
            Assert.AreEqual(2, Value);

            /*
             * OR
             */

            //int Value2;
            //bool KeyFound1 = map.TryGetValue("foo", out Value2);
            //Assert.IsFalse(KeyFound1);
            //Assert.AreEqual(0, Value2);

            //like a  List<> you can ask for 'count' in the dictionary.. 
            Assert.AreEqual(2, map.Count);

            //Object initializers
            map = new Dictionary<string, int>
            {
                {"abc", 3},
                {"def", 4}
            };
            int Value3;
            bool KeyFound3 = map.TryGetValue("abc", out Value3);
            Assert.IsTrue(KeyFound3);
            Assert.AreEqual(3, Value3);

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
