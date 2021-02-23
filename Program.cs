using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Challenges
{
	class Program
	{
		static void Main(string[] args)
		{
			// Console.WriteLine("Hello World!");
			int[] sequence = { 1, 2, 3, 4, 5, 5, 3, 2 };
			//int n = arr.Length;
			//Console.WriteLine(FirstNonRepeating(arr, n));
			Console.WriteLine("The Sequence is ");
			foreach (var s in sequence)
			{
				Console.WriteLine(s);
			}
			int result = sequence.Max();
			Console.WriteLine("Maximum Value:{0}", result);

		}
		#region FirstNonRepeating

		
		static int FirstNonRepeating(int[] arr, int n)
		{
			for (int i = 0; i < n; i++)
			{
				int j;
				for (j = 0; j < n; j++)
					if (i != j && arr[i] == arr[j])
						break;
				if (j == n)
					return arr[i];
			}
			return -1;
		}
		#endregion
	}
}
