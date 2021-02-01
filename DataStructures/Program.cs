using DataStructures.Array;
using System;

namespace DataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };

			//LinearSearchElementAndPrintIndex(arr, 60);

			int[] arr1 = { 2, 3, 4, 10, 40 };
			Console.WriteLine(Searching.BinarySearch(arr1, 50));
		}

		#region PRIVATE METHODS

		private static void LinearSearchElementAndPrintIndex(int[] arr, int elementToSearch)
		{
			int position = Searching.LinearSearch(arr, elementToSearch);

			string result = (position == -1) ? $"Element {elementToSearch} is not present in the given array"
				: $"Element {elementToSearch} is present at index {position}";

			Console.WriteLine(result);
		}

		#endregion
	}
}
