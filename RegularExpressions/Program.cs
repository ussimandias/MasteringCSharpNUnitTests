using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex pattern = new Regex(" ");
            //string text = "Usman Tarfa";
            //string[] words = pattern.Split(text);

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

	        string patternText = @"\d";
            Console.WriteLine(patternText);
            Regex pattern = new Regex(patternText);

            string text = "Usman01Tarfa02Paul";
            string[] words = pattern.Split(text);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

	        Console.ReadLine();
        }
    }
}
