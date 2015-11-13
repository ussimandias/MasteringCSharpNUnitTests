using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Fundamentals.Test
{
	[TestFixture]
	internal class GreeterTest
	{
		[Test]
		public void ThisWillFail()
		{
			Assert.AreEqual(1, 0);
		}

		[Test]
		public void SayHello_ReturnsHelloWithRecipientNameButNoSpeakerName()
		{
			Greeter greeter = new Greeter(null);
			string greeting = greeter.SayHello(" Jon");
			Assert.AreEqual("Hello Jon", greeting);
		}

		[Test]
		public void SayHello_ReturnsHelloWithRecipientNameAndSpeakerName()
		{
			Greeter greeter = new Greeter("Rob");
			string greeting = greeter.SayHello("Jon");
			Assert.AreEqual("Hello Jon from Rob", greeting);
		}

		[Test]
		public void CanConstructGreeterWithNullSpeakerName()
		{
			Greeter greeter = new Greeter(null);
			string greeting = greeter.SayHello();
			Assert.AreEqual("Hello", greeting);
		}

        [Test]
        public void SayHello_ThrowsExceptionEithNullRecipient()
        {
            Greeter greeter = new Greeter("Rob");
	        Assert.Throws<ArgumentNullException>(() => greeter.SayHello2(null));
        }


        [Test]
        public void SpeakerProperty_IsSetFromConstructor()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.AreEqual("Rob", greeter.Speaker);
            Assert.AreNotEqual("rob", greeter.Speaker);
        }

        [Test]
        public void SpeakerProperty_IsWritable()
        {
            Greeter greeter = new Greeter("Rob");
	        //greeter.Speaker = "Tom";
            Assert.AreEqual("Tom", greeter.Speaker);
	        string greeting = greeter.SayHello2("Jon");
            Assert.AreEqual("Tom", greeter.Speaker);
            Assert.AreEqual("Hello Jon from Tom", greeting);
        }
	}
}
