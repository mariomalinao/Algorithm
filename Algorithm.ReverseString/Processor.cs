using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ReverseString
{
    public class Processor
    {
        public void Run(string word)
        {
            var newWord = new StringBuilder();
            var charArray = word.ToCharArray();

            for (int index = charArray.Length - 1; index >= 0; index--)
                newWord.Append(charArray[index]);

            Console.WriteLine(newWord.ToString());
        }
    }
}
