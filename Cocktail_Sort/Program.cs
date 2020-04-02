using System;

namespace Cocktail_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Cocktail Sort Algorithm");
            Console.WriteLine("Please enter number to set the value length array:");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            int[] unsortedArray = new int[lengthArray];
            Console.WriteLine("Please enter number for fill array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine("Enter number:");
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var cocktailSortAlgorithm = new CocktailSort(unsortedArray);
            cocktailSortAlgorithm.SortRun();
            Console.WriteLine($"Required operations for sort: {cocktailSortAlgorithm.CounterOperations}");
            Console.WriteLine(cocktailSortAlgorithm);
        }
    }

    class CocktailSort
    {
        public readonly int[] _unsortedArray;
        private int currentValue;
        private int maxBorder;
        private int minBorder = 0;
        public int CounterOperations { get; private set; } = 0;

        public CocktailSort(int[] unsortedArray)
        {
            _unsortedArray = unsortedArray;
            maxBorder = _unsortedArray.Length - 1;
        }

        public void SortRun()
        {
            for (int i = minBorder; i <= maxBorder; i++)
            {
                CounterOperations++;
                if (i != maxBorder)
                {
                    if (_unsortedArray[i] > _unsortedArray[++i])
                    {
                        currentValue = _unsortedArray[i];
                        _unsortedArray[i] = _unsortedArray[--i];
                        _unsortedArray[i] = currentValue;
                        continue;
                    }
                    else { --i; continue; }
                }
                else
                {
                    maxBorder--;
                    for (int j = maxBorder; j >= minBorder; j--)
                    {
                        CounterOperations++;
                        if (j != minBorder)
                        {
                            if (_unsortedArray[j] < _unsortedArray[--j])
                            {
                                currentValue = _unsortedArray[j];
                                _unsortedArray[j] = _unsortedArray[++j];
                                _unsortedArray[j] = currentValue;
                                continue;
                            }
                            else { ++j; continue; }
                        }
                        else
                        { i = ++minBorder; break; }
                    }
                }
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
