using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ReverseSentenceOrder
{
    public class Processor
    {
        public string Run(string sentence)
        {
            var wordArray = sentence.Split(' ');
            var reverseSentence = new StringBuilder();

            for (int index = wordArray.Length - 1; index >= 0; index--)
                reverseSentence.Append($"{wordArray[index]} ");

            return reverseSentence.ToString().Trim();
        }
    }
}
