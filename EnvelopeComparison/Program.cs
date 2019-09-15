using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgumentsValidator;
using System.Reflection;

namespace EnvelopeComparison
{
	class Program
	{
		static void Main(string[] args)
		{
            Controler controler = new Controler(new UI(), new EnvelopeComparer(), new CommandArgumentsParser());
            controler.Run();
        }
	}
}
