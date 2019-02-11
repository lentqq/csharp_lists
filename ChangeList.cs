using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> comands = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (comands[0] != "Odd" && comands[0] != "Even")
            {
                if (comands[0] == "Delete")
                {
                    integers.RemoveAll(num => num == int.Parse(comands[1]));
                }
                else if (comands[0] == "Insert")
                {
                    int element = int.Parse(comands[1]);
                    int index = int.Parse(comands[2]);
                    integers.Insert(index, element);
                }
                comands = Console.ReadLine().Split(' ').ToList();
            }
            if (comands[0] == "Odd")
            {
                integers.RemoveAll(num => num % 2 == 0);
            }
            else if (comands[0] == "Even")
            {
                integers.RemoveAll(num => num % 2 != 0);
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
