using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumber
{
    class SumReversedNumber
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;

            for (int i = 0; i < integers.Count; i++)
            {
                List<char> digit = integers[i].ToString().ToList();
                digit.Reverse();
                sum += int.Parse(string.Join("", digit));
            }
            Console.WriteLine(sum);
        }
    }
}
