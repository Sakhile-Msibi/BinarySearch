using System;

namespace BinarySearch
{
    class Program
    {
        static int binarySearch(int[] arr, int lowIndex, int highIndex, int valueToSearch)
        {
            if (highIndex >= lowIndex)
            {
                int midIndex = lowIndex + (highIndex - lowIndex) / 2;

                if (arr[midIndex] == valueToSearch)
                    return midIndex;

                if (arr[midIndex] > valueToSearch)
                    return binarySearch(arr, lowIndex, midIndex - 1, valueToSearch);

                return binarySearch(arr, midIndex + 1, highIndex, valueToSearch);
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int len = arr.Length;
            int valueToSearch = 30;

            int result = binarySearch(arr, 0, len - 1, valueToSearch);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
    }
}
