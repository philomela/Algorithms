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

        public int[] SortRun()
        {
            int currentValue;
            for (int i = 0; i < _unsortedArray.Length; i++)
            {
                for (int j = 0; j < _unsortedArray.Length;)
                {
                   if (j < _unsortedArray.Length - 1 && _unsortedArray[++j] < _unsortedArray[--j])
                    {
                        currentValue = _unsortedArray[j];
                        _unsortedArray[j] = _unsortedArray[++j];
                        _unsortedArray[j] = currentValue;                        
                    }
                    j++;
                }
            }   
            return null;
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
