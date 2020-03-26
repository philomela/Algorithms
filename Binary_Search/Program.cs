using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Binary Search Algorithm");

            Console.WriteLine("Enter number for lengths array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Guess number and enter");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = new int[arrayLength];

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = i;
            }

            var binarySearch = new BinarySearchAlgorithm(inputArray);
            Console.WriteLine(binarySearch.FindItem(guessedNumber));
        }
    }

    class BinarySearchAlgorithm
    {
        private int[] arrayForSearching;

        public BinarySearchAlgorithm(int[] inputArray)
        {
            arrayForSearching = inputArray;
        }

        public int FindItem(int guessedNumber)
        {
            int minBorder = 0;
            int maxBorder = arrayForSearching.Length - 1;
            int midIndex = 0;
            int countIterator = 0;
            

            while (minBorder <= maxBorder)
            {
                countIterator++;
                midIndex = (minBorder + maxBorder) / 2;
                if (guessedNumber == arrayForSearching[midIndex])
                {
                    Console.WriteLine($"Quantity operation: {countIterator}");
                    return midIndex;
                }
                else if (guessedNumber > arrayForSearching[midIndex])
                {
                    minBorder = midIndex;
                }
                else
                {
                    maxBorder = midIndex;
                }
            }

            return 0;
        }
    }
}