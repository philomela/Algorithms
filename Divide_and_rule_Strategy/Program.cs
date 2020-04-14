using System;

namespace Divide_and_rule_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm 'Divide and rule' strategy");
            Console.WriteLine("Please enter number to set the value width Area:");
            int widthArea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number to set the value height Area:");
            int heightArea = Convert.ToInt32(Console.ReadLine());
            var resultCalculateMinSquare = new CalculatorMinSquare().CalculateMinSquare(widthArea: widthArea, heightArea: heightArea);
            Console.WriteLine("Minimum square values:"); 
            Console.WriteLine($"MinWidth: {Convert.ToString(resultCalculateMinSquare.Item1)} \n MinHeight: {Convert.ToString(resultCalculateMinSquare.Item2)}");
        }
    }

    class CalculatorMinSquare
    {
        public (int, int) CalculateMinSquare(int widthArea, int heightArea)
        {
            int _widthArea = widthArea, _heightArea = heightArea;

            var _minSquare = (height: 0, width: 0);

            if (heightArea * 2 == widthArea | widthArea * 2 == heightArea)
            {
                if (heightArea < widthArea)
                {
                    _minSquare.height = heightArea;
                    _minSquare.width = heightArea;
                    return _minSquare;
                }
                else
                {
                    _minSquare.height = widthArea;
                    _minSquare.width = widthArea;
                    return _minSquare;
                }
                
            }
            else if (heightArea == 0)
            {
                return (widthArea, widthArea);
            }
            else if (widthArea == 0)
            {
                return (heightArea, heightArea);
            }
            else if (heightArea > widthArea)
            {
                int countWidth = heightArea / widthArea;
                _heightArea = heightArea - countWidth * widthArea;
                _widthArea = widthArea;
            }
            else if (widthArea > heightArea)
            {
                int countHeight = widthArea / heightArea;
                _heightArea = heightArea;
                _widthArea = _widthArea - countHeight * heightArea;
            }

            return CalculateMinSquare(_widthArea, _heightArea);
        }
    }
}
