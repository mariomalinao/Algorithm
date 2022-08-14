using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.RemoveDuplicateCharacters
{
    public class Processor
    {
        public string Word { get; set; }
        public Processor(string word)
        {
            Word = word;
        }

        public string Run()
        {
            var noDuplicate = string.Empty;

            foreach(char c in Word)
            {
                if ((noDuplicate == string.Empty || !noDuplicate.Contains(c, StringComparison.InvariantCultureIgnoreCase)) && c != ' ')
                    noDuplicate += c;
            }

            return string.Join("",noDuplicate.ToLower().OrderBy(x => x));
        }
    }
}
