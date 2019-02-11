using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> comands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (comands[0] != "print")
            {
                if (comands[0] == "add")
                {
                    int index = int.Parse(comands[1]);
                    int element = int.Parse(comands[2]);
                    integers.Insert(index, element);
                }
                else if (comands[0] == "addMany")
                {
                    int index = int.Parse(comands[1]);
                    integers.InsertRange(index, comands.Skip(2).Select(int.Parse));
                }
                else if (comands[0] == "contains")
                {
                    int element = int.Parse(comands[1]);
                    if (integers.Contains(element))
                    {
                        Console.WriteLine(integers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (comands[0] == "remove")
                {
                    int index = int.Parse(comands[1]);
                    integers.RemoveAt(index);
                }
                else if (comands[0] == "shift")
                {
                    int position = int.Parse(comands[1]) % integers.Count;
                    var helperList = integers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helperList.Add(integers[i]);
                    }
                    integers = helperList;
                }
                else if (comands[0] == "sumPairs")
                {
                    int fixPosition = integers.Count / 2;
                    for (int i = 0; i < fixPosition; i++)
                    {
                        integers[i] += integers[i + 1];
                        integers.RemoveAt(i + 1);
                    }
                }
                comands = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            Console.WriteLine("[" + string.Join(", ",integers) + "]");
        }
    }
}
