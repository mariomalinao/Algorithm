using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ReverseEachWord
{
    public class Processor
    {
        public string Run(string sentence)
        {
            var newSentence = new StringBuilder();
            var newWord = new StringBuilder();
            var sentenceArray = sentence.Split(' ');

            for (int sentenceIndex = 0; sentenceIndex < sentenceArray.Length; sentenceIndex++)
            {
                var word = sentenceArray[sentenceIndex];
                var wordArray = word.ToCharArray();

                for(int wordIndex = wordArray.Length - 1; wordIndex >= 0; wordIndex--)
                {
                    newWord.Append(wordArray[wordIndex]);
                }

                newSentence.Append($"{newWord.ToString()} ");
                newWord.Clear();
            }

            return newSentence.ToString().Trim();
        }
    }
}
