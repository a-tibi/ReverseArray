using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArray
{
	class Program
	{
		public static List<int> reverseArray(List<int> inArray)
		{
			//inArray.Reverse();
			List<int> outArray = new List<int>();
			for (int i = inArray.Count - 1; i >= 0; i--)
			{
				outArray.Add(inArray[i]);
			}
			return outArray;
		}

		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			List<int> inArray = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(a => Convert.ToInt32(a)).ToList();

			List<int> outArray = reverseArray(inArray);

			foreach (var item in outArray)
			{
				Console.Write($"{item} ");
			}

			Console.ReadKey();
		}
	}
}
