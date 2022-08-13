using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Palindrome
{
    public class Processor
    {
        public string Run(string word)
        {
            var reverseWord = new StringBuilder();
            var wordArray = word.ToArray();

            for (int index = wordArray.Length - 1; index >= 0; index--)
                reverseWord.Append(wordArray[index]);

            if (string.Equals(word, reverseWord.ToString(), StringComparison.InvariantCultureIgnoreCase))
                return "Palindrome!";
            else
                return "Not a Palindrome!";
        }
    }
}
