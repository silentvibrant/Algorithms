using System;

namespace BinarySearch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Please choose a number between 1 and 10");

            int answer = int.Parse(Console.ReadLine());
            int? position = BinarySearch(intArray, answer);

            Console.WriteLine(position != null
                ? $"Your position is {position}"
                : $"Your number doesn't exist in the list");
            Console.ReadLine();
        }

        public static int? BinarySearch(int[] sortedIntArray, int item)
        {
            int lowNumber = 0;
            int highNumber = sortedIntArray.Length - 1;

            while (lowNumber <= highNumber)
            {
                int middleNumber = (lowNumber + highNumber) / 2;
                int guess = sortedIntArray[middleNumber];
                if (guess == item)
                    return middleNumber;
                if (guess < item)
                    lowNumber = middleNumber + 1;
                else
                    highNumber = middleNumber - 1;
            }

            return null;
        }
    }
}
