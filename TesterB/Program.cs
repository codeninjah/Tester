using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterB
{
	class Program
	{
		static void Main(string[] args)
		{
			string teststring1 = "alex programmerar för att han tycker det är en rolig syssla";

			//show only first 10 characters in the string
			var kappa = teststring1.Substring(0, 10);
			Console.WriteLine(kappa);

			//take out the blank spaces inbetween the words
			string[] ersätt = teststring1.Split(' ');
			//print the result
			foreach (string s in ersätt)
			{
				Console.Write(s);
			}

			//join the splitted words with a "-" then output the result
			string lappaihop = string.Join("-", ersätt);
			Console.WriteLine("\n" + lappaihop);

			//Substring from 0 to an index of a certain character
			string partatill = teststring1.Substring(0, teststring1.IndexOf('f'));
			Console.WriteLine(partatill);


			//Split at different elements, print the result and then join the words with a blank space
			string teststring2 = "testing for-a,couple-of;spliters";
			char[] splitWith = { ' ', '-', ',', '-', ';' };
			Console.WriteLine(teststring2);

			string[] splitMultiple = teststring2.Split(splitWith);
			foreach (string s in splitMultiple)
			{
				Console.Write(s);
			}

			Console.WriteLine("");

			string joinmultiple = string.Join(" ", splitMultiple);
			Console.WriteLine(joinmultiple);


			//Join multiple strings with a charcter of choice
			string[] multiplestrings = { "Alex", "Guy", "Bebelu", "Namn" };
			string multipletoone = string.Join(" ", multiplestrings);
			Console.WriteLine(multipletoone);

			string[] multiplestrings2 = { "Alex", "Guy", "Bebelu", "Namn" };
			string multipletoone2 = string.Join(",", multiplestrings);
			Console.WriteLine(multipletoone2);

		}
	}
}
