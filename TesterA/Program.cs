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

			//Sort and array of numbers in ascending order
			Array.Sort(arr);
			foreach (var num in arr)
			{
				Console.Write(num + " ");
			}

			//Reverse an array
			//If you want to sort in in descending order, you need to use the "Sort" funtion on the array first(as above),
			//in order to reverse the whole array. Otherwise, it will just reverse the order of the numbers and not descending
			//You can also add 2 numbers below, after arr, separated by coma. The program will sort those numbers for you and just those
			Array.Reverse(arr);
			foreach (var num in arr)
			{
				Console.Write(num + " ");
			}

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


			//Smallest under 0
			const int lowest = 0;
			foreach (int number in arr3)
			{
				if (number < lowest)
					min = Math.Min(number, min);
				Console.WriteLine($"Minsta talet under 0 är: {min}");
			}

			//Highest under 0
			const int highest = 0;
			foreach (int number in arr3)
			{
				if (number < highest)
					max = Math.Max(number, min);
				Console.WriteLine($"Största talet under 0 är: {max}");
			}

			//Get the first digit in a number
			int temp = 6578965;
			while (temp >= 10)
			{
				temp /= 10;
			}
			Console.WriteLine(temp);

			//And another way of getting the first digit
			var number2 = 550;
			var result2 = Math.Floor(number2 / Math.Pow(10, Math.Floor(Math.Log10(number2))));

			//Getting the first digit by converting to a string
			var number3 = 550;
			var result = number3.ToString().Substring(0, 1);


			//Write a double and alert if the characters aren't numbers
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

			//Same thing but less code and with an int instead of a double
			int år;
			while (!int.TryParse(Console.ReadLine(), out år))
			{
				Console.WriteLine("Ogiltigt tal");
			}


		}
	}
}
