using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseLetters = new List<string>();
            List<string> capitalCaseLetters = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in text)
            {
                if (IsCapitalLettrs(word))
                {
                    capitalCaseLetters.Add(word);
                }
                else if (IsSmallLettrs(word))
                {
                    lowerCaseLetters.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}",string.Join(", ",lowerCaseLetters));
            Console.WriteLine("Mixed-case: {0}",string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: {0}",string.Join(", ",capitalCaseLetters));
        }
        static bool IsCapitalLettrs(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || symbol >'Z')
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsSmallLettrs(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
