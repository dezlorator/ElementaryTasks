using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
    public class UI : IUserUI
    {
        public string GetUserEnvelope()
        {
            Print(StringConstants.INPUT_ENVELOPE);
            return Console.ReadLine();
        }

        public void Print(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }
    }
}
