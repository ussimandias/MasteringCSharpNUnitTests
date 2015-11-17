using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Test
{
    [TestFixture]
    public class DateTest
    {
        [Test]
        public void TimeSpanUsage()
        {
            //System.TimeSpan (.NET 1.0)
            //TimeSpan ts = new TimeSpan();
            TimeSpan fiveSeconds= TimeSpan.FromSeconds(5);
            TimeSpan halfMinute = TimeSpan.FromMinutes(.5);

            Assert.AreEqual(TimeSpan.FromMilliseconds(35000), fiveSeconds + halfMinute);

            //System.DateTime (.NET 1.0)
            //System.DateTimeOffset (.NET 2.0SP1 / .NET 3.5)
            //System.TimeZoneInfo (.NET 3.5)
        }

        [Test]
        public void DateTimeUsage()
        {
            //System.DateTime (.NET 1.0)
          DateTime myTime = new DateTime(2015, 11, 12, 9, 13, 0, DateTimeKind.Local);
          DateTime yourTime = new DateTime(2015, 11, 12, 6, 13, 0, DateTimeKind.Local);
          DateTime utcTime = new DateTime(2015, 11, 12, 14, 13, 0, DateTimeKind.Utc);
          DateTime unspecifiedNine = new DateTime(2015, 11, 12, 9, 13, 0, DateTimeKind.Unspecified);
          //DateTime unspecifiedEight = new DateTime(2015, 11, 12, 9, 13, 0, DateTimeKind.Unspecified);

            Assert.AreEqual(utcTime, myTime.ToUniversalTime());
            Assert.AreEqual(utcTime, utcTime.ToUniversalTime());

            Assert.AreEqual(myTime, myTime.ToLocalTime());
            Assert.AreEqual(myTime, utcTime.ToLocalTime());

            Assert.AreEqual(utcTime, unspecifiedNine.ToUniversalTime());
            //Assert.AreEqual(myTime, unspecifiedEight.ToLocalTime());

            DateTime bedtime = myTime + TimeSpan.FromHours(2);
            Assert.AreEqual(new DateTime(2015, 11, 12, 11, 13, 0, DateTimeKind.Local), bedtime );
        }

        [Test]
        public void OtherMethods()
        {
            //System.DateTimeOffset (.NET 2.0SP1 / .NET 3.5)
            //System.TimeZoneInfo (.NET 3.5)
        }

        [Test]
        public void DateTimeOffSet()
        {
            //System.DateTimeOffset (.NET 2.0SP1 / .NET 3.5)
            
            DateTimeOffset myTime = new DateTimeOffset(2015, 11, 12, 9, 13, 0, TimeSpan.FromHours(1));
            Console.WriteLine(  myTime);
            Console.WriteLine(myTime.ToUniversalTime());

            //System.TimeZoneInfo (.NET 3.5)
        }
    }
}
