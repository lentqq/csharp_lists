using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bombNumber = command[0];
            int power = command[1];
            int position = numbers.IndexOf(bombNumber);
            int sum;
            while (numbers.Contains(bombNumber))
            {
                if (position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }
                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, power + 1 + position - 0);
                }
                else if (position + power >= numbers.Count)
                {
                    numbers.RemoveRange(position - power, power + 1 + numbers.Count - 1 - position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }
            }
            sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
