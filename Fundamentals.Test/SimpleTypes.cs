using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;

namespace Fundamentals.Test
{
    [TestFixture]
    class SimpleTypes
    {
	    [Test]
	    public void DisplayValues()
	    {
		    double x = 0.1;
		    //Console.WriteLine(DoubleConverter.ToExactString(x));
		    x += 0.000001;
            //Console.WriteLine(DoubleConverter.ToExactString(x));
            Assert.AreEqual(0.100001, x);		    
	    }
    }

    [TestFixture]
    class StringTest
    {
        [Test]
        public void Length()
        {
            string a = "hello";
            Assert.AreEqual(5, a.Length);
          
        }

        [Test]
        public void NullTermination()
        {
	        char[] nullTerminated = {'h', 'e', 'l', 'l', 'o', '\0'};
	        Console.WriteLine(nullTerminated);

        }

        [Test]
        public void Literals()
        {
	        char x = 'x';
	        string y = "y";
	        string z = @"z\0a";

        }

        [Test]
        public void Assignment()
        {        
            string x = "hello";
	        string y = x;

	        x = x.Replace('h', 'j');
            Assert.AreEqual("jello", x);
            Assert.AreEqual("hello", y);           
        }

        [Test]
        public void DiferentEqualObjects()
        {
            string x = "hello";
            string y = x;

            x = x.Replace('h', 'j');
	        object o1 = x;
	        object o2 = "jello";

            Assert.AreNotSame(o1, o2);
            Assert.IsFalse(o1 == o2);
            Assert.IsTrue(o1.Equals(o2));
        }

        [Test]
        public void DiferentEqualStrings()
        {
            string x = "hello";
            string y = x;

            x = x.Replace('h', 'j');
            string s1 = x;
            string s2 = "jello";

            Assert.AreNotSame(s1, s2);
            Assert.IsTrue(s1 == s2);
            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(object.Equals(s1, s2));
        }

        [Test]
        public void InterningOfConstants()
        {         
            string x = "hello";
            string y = "hello";
            Assert.AreSame(x, y);
        }

        [Test]
        public void InterningOfConcatenation()
        {
            string x = "hello";
            string y = "he" + "llo";
            Assert.AreSame(x, y);
        }

        [Test]
        public void NonInterningOfNonConstants()
        {
	        string he = "he";
            string x = "hello";
            string y = he + "llo";
            Assert.AreNotSame(x, y);
            Assert.AreEqual(x, y);
        }

        [Test]
        public void BadConcatenation()
        {
            string simple = new string('x', 100000);

	        string bad = "";
	        for (int i = 0; i < 100000; i++)
	        {
		        bad = bad + "x";
	        }
            Assert.AreEqual(simple, bad);
        }

        [Test]
        public void GoodConcatenation()
        {
            string simple = new string('x', 100000);
            StringBuilder builder = new StringBuilder();

            string bad = "";
            for (int i = 0; i < 100000; i++)
            {
	            builder.Append("x");
            }

	        string good = builder.ToString();
	        builder.Append("this won't appear in good");
            Assert.AreEqual(simple, good);
        }

        [Test]
        public void BadUseOfStringBildr()
        {
            string x = "x";
            string y = "y";

            StringBuilder builder = new StringBuilder();
	        builder.Append("x");
            builder.Append(" ");
            builder.Append("y");

	        string result = builder.ToString();           
            Assert.AreEqual("x y", result);
        }

        [Test]
        public void GoodUseOfStringBuilder()
        {        
            string x = "x";
            string y = "y";
  	        string result = x + " " + y;
            Assert.AreEqual("x y", result);
        }

        [Test]
        public void CompilerTranslationOfConcatenation()
        {
            string x = "x";
            string y = "y";
            string result = String.Concat(x, " ", y);
            Assert.AreEqual("x y", result);
        }

        [TestAttribute]
        public void StringJoin()
        {
            string[] values = {"x", " ", "y"};
	        string commaSeparated = string.Join(",", values);
            
            Assert.AreEqual("x, ,y", commaSeparated);           
        }

        [TestAttribute]
        public void StringFormat()
        {
            string x = "x";
            string y = "y";
            string result = String.Format("{0} {1}", x, y);
            Assert.AreEqual("x y", result); 
        }

        [TestAttribute]
        public void StringFormat2()
        {
            string x = "x";
            string y = "y";
            string result = String.Format("{1} {0}", x, y);
            Assert.AreEqual("y x", result);
        }

        [TestAttribute]
        public void StringFormat3()
        {
            int x = 100;
            string y = "y";
            string result = String.Format("x={0} y={1}", x, y);
            Assert.AreEqual("x=100 y=y", result);
        }

        [TestAttribute]
        public void StringFormat4()
        {
            int value = 100;
            string y = "y";
            string result = String.Format("value=0x{0:x} y={1}", value, y);
            Assert.AreEqual("value=0x64 y=y", result);
        }

        [TestAttribute]
        public void StringFormat5()
        {
	        decimal price = 10.50m;
            string result = String.Format("price={0:C}", price);
            Assert.AreEqual("price=$10.50", result);
        }

        [TestAttribute]
        public void InternMethod()
        {
	        string x = "hello";
	        string y = "jello".Replace('j', 'h');
            Assert.AreNotSame(x,y);
            string z = String.Intern(y);
            Assert.AreSame(x,y);
        }
    }
}
