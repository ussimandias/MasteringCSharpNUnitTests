using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
	        string x = "hello";
	        string y = x.Substring(1, length: 3);
	        string z = x.Substring(2);

	        Console.WriteLine(y);
            Console.WriteLine(z);

	        int firstEllIndex = x.IndexOf('l');
	        Console.WriteLine(firstEllIndex);
            int secondEllIndex = x.IndexOf('l', firstEllIndex);
            Console.WriteLine(secondEllIndex);
            int thirdEllIndex = x.IndexOf('l', secondEllIndex);
            Console.WriteLine(thirdEllIndex);

	        string a = "Usman Tarfa";
	        int spaceIndex = a.IndexOf(' ');
	        if (spaceIndex != -1)
	        {
		        string first = a.Substring(0, spaceIndex);
	            string last = a.Substring(spaceIndex + 1);
	            Console.WriteLine("First = {0}; Last = {1}", first,last);
	        }
	        else
	        {
		        Console.WriteLine("No Match");
	        }

	        string ce = "0,1,,3,,5,,7";
	        string[] words = ce.Split(',');
	        for (int i = 0; i < words.Length; i++)
	        {
		        Console.WriteLine("{0}: {1}", i, words[i]);
	        }
	        Console.WriteLine("Done!");

            string xe = "0,1,,3,,5,,7";
            string[] wd = ce.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wd.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, wd[i]);
            }
            Console.WriteLine("Done!");
	        
	        Console.ReadLine();
        }
    }
}
