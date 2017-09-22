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

		}
	}
}
