using System;
using System.Collections.Generic;
using System.Linq;

namespace listsDemo
{
    class listsDemo
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToList();
            numbers.Sort();
            numbers.Add(int.MaxValue);
            int currentNumber = numbers[0];
            int count = 1;
            
            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {count}");
                    currentNumber = numbers[i];
                    count = 1;
                }
            }
        }
    }
}
