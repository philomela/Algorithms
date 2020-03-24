using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Binary Search Algorithm");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = new int[arrayLength];

            for (int i = 0; i <= inputArray.Length; i++)
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
            int minIndexArray = arrayForSearching[0];
            int maxIndexArray = arrayForSearching.Length - 1;
            int currentPosition = 0;

            while (arrayForSearching[arrayForSearching.Length - 1 / 2] != guessedNumber)
            {
                if (guessedNumber > arrayForSearching[currentPosition]) minIndexArray = arrayForSearching[arrayForSearching.Length - 1 / 2];

            }

            return 0;
        }
    }
}