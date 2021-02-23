using System;

namespace Coding_Challenges
{
	class Program
	{
		static void Main(string[] args)
		{
			// Console.WriteLine("Hello World!");
			int[] arr = { 9, 4, 9, 6, 7, 4 };
			int n = arr.Length;
			Console.WriteLine(FirstNonRepeating(arr, n));
			

		}
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
	}
}
