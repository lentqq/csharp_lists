using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            integers.Sort();

            int currentNumber = integers[0];
            int currentCount = 1;
            integers.Add(int.MaxValue);

            for (int i = 1; i < integers.Count; i++)
            {
                if (currentNumber == integers[i])
                {
                    currentCount++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {currentCount}");
                    currentNumber = integers[i];
                    currentCount = 1;
                }
            }
        }
    }
}
