using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var squareNumbers = new List<int>();

            foreach (var num in integers)
            {
                if (Math.Sqrt(num) ==(int) Math.Sqrt(num))
                {
                    squareNumbers.Add(num);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
