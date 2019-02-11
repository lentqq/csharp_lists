using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEquantNumber
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[ i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
