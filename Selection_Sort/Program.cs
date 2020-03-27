using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Selection Sort Algorithm");

            Console.WriteLine("Enter number for lengths array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter random numbers to fill an array");
            int[] unsortedArray = new int[arrayLength];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine("Enter number:");
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thanks! Sorting...");

            var selectionSort = new SelectionSortAlgorithm(unsortedArray);
            selectionSort.RunSort();
        }
    }

    class SelectionSortAlgorithm
    {
        private readonly int[] unsortedArray;
        private int[] sortedArray;

        public SelectionSortAlgorithm(int[] inpArray)
        {
            unsortedArray = inpArray;
        }

        private bool ComparisonElements(int currentElement, int inputElement)
        {
            return true;
        }
       
        public int[] RunSort()
        {

            return new int[3];
        }

        public override string ToString()
        {
            string elementsArray = null;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                elementsArray = $"[{unsortedArray[i]}]"; 
            }
            return elementsArray;
        }
        
    }
}
