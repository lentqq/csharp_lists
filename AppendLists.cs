using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine()
                .Split('|')
                .ToList();

            lists.Reverse();
            foreach (var text in lists)
            {
                var textArr = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var joined = string.Join(" ", textArr);
                Console.Write($"{joined} ");
            }
            Console.WriteLine();
        }
    }
}
