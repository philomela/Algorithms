using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Bubble Sort Algorithm");
            Console.WriteLine("Please enter number to set the value length array:");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            int[] unsortedArray = new int[lengthArray];
            Console.WriteLine("Please enter number for fill array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine("Enter number:");
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var bubbleSortAlgorithm = new BubbleSort(unsortedArray);
            bubbleSortAlgorithm.SortRun();
            Console.WriteLine(bubbleSortAlgorithm);
        }
    }

    class BubbleSort
    {
        private readonly int[] _unsortedArray;

        public BubbleSort(int[] unsortedArray)
        {
            _unsortedArray = unsortedArray;
        }

        public void SortRun()
        {
            int currentValue;
            int maxBorder = _unsortedArray.Length;

            for (int i = 0; i < maxBorder; i++)
            {
                for (int j = i + 1; j < _unsortedArray.Length; j++, i++)
                {
                    if (_unsortedArray[i] > _unsortedArray[j])
                    {
                        currentValue = _unsortedArray[i];
                        _unsortedArray[i] = _unsortedArray[j];
                        _unsortedArray[j] = currentValue;
                    }
                }
                maxBorder = --maxBorder;
                i = -1;
            }
        }

        public override string ToString()
        {
            string elementsList = null;

            for (int i = 0; i < _unsortedArray.Length; i++)
            {
                elementsList += $"[{_unsortedArray[i]}]";
            }
            return elementsList;
        }
    }
}
