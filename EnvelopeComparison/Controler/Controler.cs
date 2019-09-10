using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgumentsValidator;
using NLog;

namespace EnvelopeComparison
{
    public class Controler
    {

        #region private

        private static Logger logger = LogManager.GetCurrentClassLogger();

        private Envelope firstEnvelope;

        private Envelope secondEnvelope;

        private IEnvelopeComparer compareEnvelops;

        private IArgumentsValidator argumentsValidator;

        private ICommandArgumentsParser commandArgumentsParser;

        private readonly IUserUI UI;

        private const int Command_Arguments_Array_Length = 2;

        #endregion

        public Controler(IUserUI UI)
        {
            this.UI = UI;
        }

        private void Initialize()
        {
            compareEnvelops = new EnvelopeComparer();
            commandArgumentsParser = new CommandArgumentsParser();
            logger.Info("Parser and comparer objects were created");
        }

        public void Run()
        {
            string usersChoose;
            do
            {
                Initialize();
                firstEnvelope = GetEnvelope(commandArgumentsParser.SplitStringIntoArray
                    (UI.GetUserEnvelope()));
                secondEnvelope = GetEnvelope(commandArgumentsParser.SplitStringIntoArray
                    (UI.GetUserEnvelope()));
                var result = compareEnvelops.CompareEnvelops(firstEnvelope, secondEnvelope);
                switch (result)
                {
                    case EnvelopeCompareStages.SecondIntoFirst:
                        Console.WriteLine(StringConstants.SECOND_IN_FIRST);
                        break;
                    case EnvelopeCompareStages.FirstIntoSecond:
                        Console.WriteLine(StringConstants.FIRST_IN_SECOND);
                        break;
                    case EnvelopeCompareStages.CannotFit:
                        Console.WriteLine(StringConstants.NONE_CAN_PUT);
                        break;
                }
                Console.WriteLine(StringConstants.IF_CONTINUE);
                usersChoose = Console.ReadLine();
            }
            while (ContinueOrNot(usersChoose));
        }

        private bool ContinueOrNot(string stringToCheck)
        {
            return ((stringToCheck.ToUpper() == "Y") || 
                (stringToCheck.ToUpper() == "YES"));
        }
        
        private Envelope GetEnvelope(string[] commandArgumenrs)
        {
            while(!CheckCommandArguments(commandArgumenrs))
            {
                UI.Print("Try again");
                commandArgumenrs = commandArgumentsParser.SplitStringIntoArray
                    (UI.GetUserEnvelope());
            }
            return new Envelope(double.Parse(commandArgumenrs[0]), 
                double.Parse(commandArgumenrs[1]));
        }

        private bool CheckCommandArguments(string []commandArgumenrs)
        {
            argumentsValidator = new ArgsValidator();
            logger.Info("Validator object was created");
            if (!argumentsValidator.CheckArgsArrayLength(commandArgumenrs, 
                Command_Arguments_Array_Length))
            {
                UI.Print(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);
                logger.Error(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);

                return false;
            }
            double height = 0;
            double width = 0;
            if (!(argumentsValidator.TryParseDouble(commandArgumenrs[0], ref height)) ||
                !(argumentsValidator.TryParseDouble(commandArgumenrs[1], ref width)))
            {
                UI.Print(StringConstants.WRONG_ARGS_TYPE);
                logger.Error(StringConstants.WRONG_ARGS_TYPE);

                return false;
            }
            if (!(argumentsValidator.CheckDoubleNumberRange(height, 0, double.MaxValue)) ||
               !(argumentsValidator.CheckDoubleNumberRange(width, 0, double.MaxValue)))
            {
                UI.Print(StringConstants.WRONG_CONVERT_SIDE_SIZE);
                logger.Error(StringConstants.WRONG_CONVERT_SIDE_SIZE);

                return false;
            }

            return true;
        }

    }
}
