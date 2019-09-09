using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    static class ClientUI
    {

        public static void ConsoleOutPut(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }
        public static string UserInput()
        {
            Console.WriteLine(StringConstants.INFO_ABOUT_INPUT);
            return GetInput();
        }

        public static void OutputResult(SortedSetOfTriangles triangleSortedSet)
        {
            Console.WriteLine("============= Triangles list: ===============");
            foreach (string infoAboutTriangle in triangleSortedSet)
            {
                Console.WriteLine(infoAboutTriangle);
            }
        }

        public static string AskIfUserWantToContinue()
        {
            Console.WriteLine(StringConstants.IF_WANT_TO_CONTINUE);
            return GetInput();
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
