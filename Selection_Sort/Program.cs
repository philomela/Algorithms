using System;
using System.Collections.Generic;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Selection Sort Algorithm");

            Console.WriteLine("Enter number for lengths array");
            int listLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter random numbers to fill an array");
            List<int> unsortedList = new List<int>();
            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine("Enter number:");
                unsortedList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Thanks! Sorting...");

            var selectionSort = new SelectionSortAlgorithm(unsortedList);
            selectionSort.RunSort();
            Console.WriteLine($"Sorted array: {selectionSort}");
        }
    }

    class SelectionSortAlgorithm
    {
        private readonly List<int> unsortedList;
        private List<int> sortedList;
        private int countOperation;

        public SelectionSortAlgorithm(List<int> inpList)
        {
            unsortedList = inpList;
            sortedList = new List<int>();
            countOperation = inpList.Count;
        }

        private int FindSmallest()
        {
            int smallest = unsortedList[0];
            int smallestIndex = 0;

            for (int i = 1; i < unsortedList.Count; i++)
            {
                if (unsortedList[i] < smallest)
                {
                    smallest = unsortedList[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public void RunSort()
        {
            for (int i = 0; i < countOperation; i++)
            {
                int smallest_index = FindSmallest();
                sortedList.Add(unsortedList[smallest_index]);
                unsortedList.RemoveAt(smallest_index);
            }
        }

        public override string ToString()
        {
            string elementsList = null;

            for (int i = 0; i < sortedList.Count; i++)
            {
                elementsList += $"[{sortedList[i]}]";
            }
            return elementsList;
        }
    }
}
