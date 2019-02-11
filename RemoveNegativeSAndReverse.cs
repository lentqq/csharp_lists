using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativeSAndReverse
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            integers.Reverse();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] < 0)
                {
                    integers.RemoveAt(i);
                    i--;
                }
            }
            if (integers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", integers));
            }
        }
    }
}
