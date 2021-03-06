﻿using System;
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
			//Here: a blank space
			string[] multiplestrings = { "Alex", "Guy", "Bebelu", "Namn" };
			string multipletoone = string.Join(" ", multiplestrings);
			Console.WriteLine(multipletoone);

			//A comma
			string[] multiplestrings2 = { "Alex", "Guy", "Bebelu", "Namn" };
			string multipletoone2 = string.Join(",", multiplestrings);
			Console.WriteLine(multipletoone2);

			//If you want a certain string to print out, in this case, the one at position 0 in multiplestrings2
			string multi1 = multiplestrings2[0];
			Console.WriteLine(multi1);

			//if you want 2 certain strings from the array and divided by a blank space
			string multi2 = string.Join(" ", multiplestrings2[1], multiplestrings2[2]);
			//you can also do it lik this:
			string multi = multiplestrings2[1] + " " + multiplestrings2[2];
			Console.WriteLine("Notice this");
			Console.WriteLine(multi);
			Console.WriteLine(multi2);

			//No char, just joining the words into one word
			string[] multiplestrings3 = { "Alex", "Guy", "Bebelu", "Namn" };
			string multipletoone3 = string.Join("", multiplestrings);
			Console.WriteLine(multipletoone3);

			//All indexes of a certain character, in this case "o"
			int start = 0;
			string a = "potatismos";
			int index;
			while ((index = a.IndexOf('o', start)) >= 0)
			{
				//If you want the place without starting from 0, but from 1, then write the following line
				//index += 1;
				Console.WriteLine(index);
				start = index + 1;
			}

			//if you want uppercases first in order
			List<string> l = new List<string>();
			l.Add("smtp:a");
			l.Add("smtp:c");
			l.Add("SMTP:b");
			l.Add("SMTP:d");

			l.Sort(StringComparer.Ordinal);

			for (int i = 0; i < l.Count; i++)
			{
				Console.WriteLine(" " + l[i]);
			}


			//if you want lowercases first in order
			List<string> m = new List<string>();
			m.Add("smtp:a");
			m.Add("smtp:c");
			m.Add("SMTP:b");

			m.OrderByDescending(item => item).ToList();

			foreach (var lowercase in m)
			{
				Console.WriteLine(lowercase);
			}


			//If you want to ignore lowers and uppers and instead just order by the alphabet
			List<string> x = new List<string>();
			x.Add("smtp:a");
			x.Add("smtp:c");
			x.Add("SMTP:b");
			x.Add("student");
			x.Add("Student");
			x.Add("students");
			x.Add("Students");
			x.Sort();

			foreach (var lowercase in x)
			{
				Console.WriteLine(lowercase);
			}


			//Sort numbers first and then text
			List<string> voltage = new List<string>() { "1", "5", "500", "LT", "RT", "400", "2B", "7H", "3J" };

			List<string> result = voltage
			  .OrderBy(s =>
			  {
				  int i = 0;
				  return int.TryParse(s, out i) ? i : int.MaxValue;
			  })
			  .ThenBy(s => s)
			  .ToList();

			foreach (var num in result)
			{
				Console.WriteLine(num + " ");
			}


		}
	}
}
