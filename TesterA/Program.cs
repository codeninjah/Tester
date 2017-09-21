using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterA
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[5];

			arr[0] = 1;
			arr[1] = 5;
			arr[2] = 6;
			arr[3] = 0;
			arr[4] = 10;

			int min = arr.Min();
			int max = arr.Max();
			Console.WriteLine("min is " + min);
			Console.WriteLine("mnax is " + max);

			int[] arr2 = { 20, 55, 74, 32, 0 };
			int min2 = arr2.Min();
			int max2 = arr2.Max();
			Console.WriteLine($"Min is {min2} and max is {max2}");

			int[] arr3 = { -10, -5, 0, 4, 2, 1 };

			//Gets the smallest number after 0
			int minst = arr3.Where(n => n > 0).Min();
			Console.WriteLine("Minsta ovan 0 är: " + minst);


			//Gets the biggest number after 0
			int störst = arr3.Where(n => n > 0).Max();
			Console.WriteLine("Största ovan 0 är: " + störst);

			
			//Minsta under 10
			const int lowest = 0;
			foreach (int number in arr3)
			{
				if (number < lowest)
					min = Math.Min(number, min);
				Console.WriteLine($"Minsta under 0 är: {min}");
			}

			//Strörsta under 0
			const int highest = 0;
			foreach (int number in arr3)
			{
				if (number < highest)
					max = Math.Max(number, min);
				Console.WriteLine($"Största under 0 är: {max}");
			}


			//Write a double that converts to an int, alert if the characters aren't numbers
			double Base;
			while (true)
			{
				if (double.TryParse(Console.ReadLine(), out Base))
				{
					break;
				}
				else
				{
					Console.WriteLine("Det där vart inte ett giltligt decimal tal, vänligen försök igen.");
				}
			}

			//Same thing but less code
			int år;
			while (!int.TryParse(Console.ReadLine(), out år))
			{
				Console.WriteLine("Ogiltigt tal");
			}


		}
	}
}
