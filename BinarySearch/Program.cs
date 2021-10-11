using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = new[] {1, 9, 3, 11, 1099, 14, 12, 11, 35, 10, 19, 183};
            Array.Sort(numArray);
            Console.WriteLine(BinarySearchDisplay(numArray, 14));
        }
        public static object BinarySearchDisplay(int[] arr, int key)
        {

            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return mid;
                } 
                if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return "Not in the array.";
        }
    }
}
