using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FindPatternItText
{
    class PatternReplace
    {
        
        public int ReplacePattern(string path, string pattern, string newString)
        {
            var allStrings = File.ReadAllLines(path);
            // TODO СОЗДАВАТЬ НОВЫЙ ФАЙЛ И В НЕМ МЕНЯТЬ
            int numberOfChangedLines = 0;
            using (StreamWriter write = new StreamWriter(path))
            {
                foreach (string singleLine in allStrings)
                {
                    if (singleLine.Contains(pattern))
                    {
                        numberOfChangedLines++;
                    }
                    write.WriteLine(singleLine.Replace(pattern, newString));
                }

            }

            return numberOfChangedLines;
        }

    }
}
