using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasteringCSharp.Test
{
	[TestFixture]
	public class ControlFlow
	{
		[Test]
		public void Return()
		{
			Console.WriteLine("Hello");
			return;
		}

        //[Test]
        //public int MethodReturningInt32()
        //{
        //    //int x = 10;
        //    //byte y = 10;
        //    return 13;
        //    //Assert.AreEqual(13, MethodReturningInt32());
        //}

		[Test]
		public void If()
		{
			int x = 10;
			if (x > 5)
			{
				Console.WriteLine("x is greater than 5");
			}

			if (x < 5)
			{
				Console.WriteLine("x is less than 5");
			}
			else
			{
				Console.WriteLine("x is not less than 5");
			}

			//Common Way
			//bool y = false;
			//if (!y){}           
		}

		[Test]
		public void While()
		{
			int x = 10;
			while (x < 5)
			{
				Console.WriteLine(x);
				x++;
			}

			Console.WriteLine("Final value of x: {0}", x);
		}

		[Test]
		public void DoWhile()
		{
			int x = 10;
			do
			{
				Console.WriteLine(x);
				x++;
			} while (x < 15);

			Console.WriteLine("Final value of x: {0}", x);
		}


		[Test]
		public void BreakInWhile()
		{
			int x = 10;
			while (x < 15)
			{
				Console.WriteLine(x);

				if (x%3 == 0)
				{
					break;
				}

				x++;
			}

			Console.WriteLine("Final value of x: {0}", x);
		}

		[Test]
		public void ContinueInWhile()
		{
			int x = 10;
			while (x < 15)
			{
				Console.WriteLine(x);
				if (x%3 == 0)
				{
					Console.WriteLine("Skipping...");
					x += 2;
					continue;
				}
				x++;
			}

			Console.WriteLine("Final value of x: {0}", x);
		}

		[Test]
		public void ForLoop()
		{
			for (int x = 10; x < 10; x++)
			{
				//body;
				Console.WriteLine(x);
			}
		}

		[Test]
		public void BreakingInWhile()
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.WriteLine("i is :{0}  j is :{1}", i, j);
					if (i + j == 4)
					{
						break;
					}
				}
			}
		}

		[Test]
		public void ForEach()
		{
			string[] strings = {"Ed", "Ches", "Gene", "Mike", "Rob"};

			/*for (int i = 0; i < strings.Length; i++)
			{
				Console.WriteLine(strings[i]);
			}*/

			foreach (string name in strings)
			{
				Console.WriteLine(name);
			}
		}
        [Test]
		public void ForEachOverList()
		{
            List<string> strings = new List<string> { "Ed", "Ches", "Gene", "Mike", "Rob" };
            //List<string> strings = new List<string>();
            //strings.Add("thes");
            //strings.Add("Ches"); 
            //strings.Add("shes"); 
            //strings.Add("dhes"); 
            //strings.Add("phes");

            /*foreach (string words in strings)
			{
                Console.WriteLine(words);
			}*/

	        string value;
	        using (IEnumerator<string> iterator = strings.GetEnumerator())
	        {
		        while (iterator.MoveNext())
		        {
			        value = iterator.Current;
			        Console.WriteLine(value);
		        };
	        }
		}

	}
}
