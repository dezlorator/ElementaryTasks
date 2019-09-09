using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPatternItText
{
    class Program
    {
        static void Main(string[] args)
        {
            Controler controler = new Controler();
            controler.Run(args);
            Console.ReadLine();
        }
    }
}
