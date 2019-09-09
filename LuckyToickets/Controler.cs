using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientUI;
using FileValidatorLibrary;
using System.IO;
using NLog;

namespace LuckyTickets
{
    class Controler
    {
        #region private

        private ILuckyTicketValidator ticketValidator;

        private ILuckyTicketAlgorithm luckyTicketAlgorithm;

        private ILuckyTicketParser luckyTicketParser;

        private List<Ticket> ticketList;

        private Logger logger;

        private const int SIZE_OF_THE_COMMAND_ARGUMENTS_ARRAY = 2;

        #endregion

        private void Initialize()
        {
            ticketValidator = new LuckyTicketValidator();
            luckyTicketParser = new LuckyTicketParser();
            ticketList = new List<Ticket>();
            logger = LogManager.GetCurrentClassLogger();
            logger.Info("Parser and validator objects were created");
        }

        public void Run(string[] commandArguments )
        {
            Initialize();
            if (!ValidateArguments(commandArguments))
            {
                return;
            }

            var algorithmType = GetAlgorithmType(commandArguments[1]);
            using (StreamReader reader = new StreamReader(commandArguments[0]))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    ticketList.AddRange(luckyTicketParser.CheckTicketsInLine(line));
                }
            }
            switch (algorithmType)
            {
                case AlgorithmType.MoskowAlgirithm:
                    luckyTicketAlgorithm = new MoskowAlgorithm();
                    logger.Info(StringConstants.MOSKOW_ALGORITHM_USED);
                    break;
                case AlgorithmType.PiterAlgirithm:
                    luckyTicketAlgorithm = new PiterAlgorithm();
                    logger.Info(StringConstants.PITER_ALGORITHM_USED);
                    break;
            }
            UI.ConsoleOutPut(string.Format(StringConstants.OUTPUT_RESULT, luckyTicketAlgorithm.Algorithm(ticketList)));
        }

        private bool ValidateArguments(string[] commandArguments)
        {
            if (commandArguments.Length != SIZE_OF_THE_COMMAND_ARGUMENTS_ARRAY)
            {
                UI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS, StringConstants.INFO_ABOUT_INPUT);
                logger.Error(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);

                return false;
            }

            if (!CheckFile(commandArguments[0]))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_INPUT);
                return false;
            }

            if (!ticketValidator.IsRightAlgorithm(commandArguments[1]))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_INPUT);
                logger.Error(StringConstants.WRONG_ALGORITHM);

                return false;
            }

            return true;
        }

        private bool CheckFile(string filePath)
        {
            IValidator validator = new FileValidator();
            
            if (!validator.DoesFileExist(filePath))
            {
                UI.ConsoleOutPut(StringConstants.FILE_NOT_FOUND);
                logger.Error(StringConstants.FILE_NOT_FOUND);

                return false;
            }

            else if (!validator.CheckFileType(filePath, ".txt"))
            {
                UI.ConsoleOutPut(StringConstants.WRONG_FILE_TYPE);
                logger.Error(StringConstants.WRONG_FILE_TYPE);

                return false;
            }

            else if (validator.IsFileEmpty(filePath))
            {
                UI.ConsoleOutPut(StringConstants.EMPTY_FILE);
                logger.Error(StringConstants.EMPTY_FILE);

                return false;
            }

            return true;
        }

        private AlgorithmType GetAlgorithmType(string userChoose)
        {
            if (userChoose.ToUpper() == "PITER")
            {
                return AlgorithmType.PiterAlgirithm;
            }
            else
            {
                return AlgorithmType.MoskowAlgirithm;
            }
        }
    }
}
