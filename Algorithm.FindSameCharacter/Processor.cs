using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FindSameCharacter
{
    public class Processor
    {
        public string FindCharacterCount(string word)
        {
            var charCounter = new Dictionary<char, int>();

            foreach (char c in word.ToLower())
            {
                if (c == ' ')
                    continue;

                if (!charCounter.ContainsKey(c))
                    charCounter.Add(c, 1);
                else
                    charCounter[c]++;
            }

            return String.Join($"{Environment.NewLine}", charCounter.Select(x => {
                return $"{x.Key} - {x.Value}";
            }).OrderByDescending(x => x.Split(" - ")[1]));
        }

        public string FindDuplicates(string word)
        {
            var charCounter = new Dictionary<char, int>();

            foreach (char c in word.ToLower())
            {
                if (c == ' ')
                    continue;

                if (!charCounter.ContainsKey(c))
                    charCounter.Add(c, 1);
                else
                    charCounter[c]++;
            }

            return String.Join($"{Environment.NewLine}", charCounter
                .Where(x => x.Value > 1)
                .Select(x => x.Key)
                .OrderBy(x => x));
        }
    }
}
