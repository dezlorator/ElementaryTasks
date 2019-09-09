using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI
{
    public static class UI
    {

        public static void ConsoleOutPut(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        public static void ConsoleOutPut(string firstStringToPrint, string secondStringToPrint)
        {
            Console.WriteLine(firstStringToPrint);
            Console.WriteLine(secondStringToPrint);
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}