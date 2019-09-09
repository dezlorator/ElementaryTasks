using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindPatternItText
{
    class PatternSearcher
    {

        public int FindPatternInFile(string path, string pattern)
        {
            int numberOfPatterns = 0;
            foreach(string line in File.ReadLines(path))
            {
                if (line.Contains(pattern))
                {
                    numberOfPatterns += line.Split(new string[] { pattern }, StringSplitOptions.None).Length - 1;
                }
            }

            return numberOfPatterns;
        }

    }
}
