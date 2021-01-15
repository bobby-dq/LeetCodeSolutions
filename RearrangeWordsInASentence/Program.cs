using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RearrangeWordsInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrangeWords("Leetcode is cool"));
        }

        public static string ArrangeWords(string text)
        {
            string[] wordsArray = text.ToLower().Split(' ').OrderBy(w => w.Length).ToArray();
            string wordsArrayString = String.Join(' ', wordsArray);
            return wordsArrayString.Substring(0, 1).ToUpper() + wordsArrayString.Substring(1);
        }
    }
}
