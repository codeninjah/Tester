using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterC
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> Lista = new List<string>();
			Lista.Add("student");
			Lista.Add("student");
			Lista.Add("student");
			Lista.Add("student");

			//changing to uppercase every string that has place in a place divided by 2 in the list
				for (int i = 0; i < Lista.Count; i++)
				{
					if (i % 2 == 0 && i > 0)
					{
						Lista[i] = Lista[i].ToUpper();
						Console.WriteLine(Lista[i].ToString());
					}
					else
						Console.WriteLine(Lista[i].ToLower());
				}
				
			

		}

	}
	}

