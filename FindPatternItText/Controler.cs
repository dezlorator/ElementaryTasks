using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileValidatorLibrary;
using ClientUI;

namespace FindPatternItText
{
    class Controler
    {
        #region private

        private const int NUMBER_OF_ARGUMENTS_TO_SEARCH = 2;

        private const int NUMBER_OF_ARGUMENTS_TO_SEARCH_AND_SWAP = 3;

        #endregion

        public void Run(string[] commandArguments)
        {
            if (commandArguments.Length != NUMBER_OF_ARGUMENTS_TO_SEARCH && commandArguments.Length != NUMBER_OF_ARGUMENTS_TO_SEARCH_AND_SWAP)
            {
                UI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS, StringConstants.INFO_ABOUT_INPUT);
                return;
            }

            if(!CheckFile(commandArguments[0]))
            {
                return;
            }
      
            ProgramMode programMode = ChooseProgramMode(commandArguments.Length);
            switch (programMode)
            {
                case ProgramMode.SearchPattern:
                    PatternSearcher patternSearcher = new PatternSearcher();
                    int numberOfPatterns = patternSearcher.FindPatternInFile(commandArguments[0], commandArguments[1]);
                    UI.ConsoleOutPut(string.Format("Number of patterns in text = {0}", Convert.ToString(numberOfPatterns)));
                    break;
                case ProgramMode.SearchPatternAndSwap:
                    PatternReplace patternReplace = new PatternReplace();
                    int numberOfChanges = patternReplace.ReplacePattern(commandArguments[0], commandArguments[1], commandArguments[2]);
                    UI.ConsoleOutPut(string.Format("Number of changed lines in text = {0}", Convert.ToString(numberOfChanges)));
                    break;
            }

            //TODO СТРОКИ ПЕРЕДАВАТЬ В АЛГОРИТМЫ(ДЛЯ ТЕСТОВ)
        }

        private bool CheckFile(string filePath)
        {
            bool result = true;
            FileValidator validator = new FileValidator();

            if(!validator.DoesFileExist(filePath))
            {
                UI.ConsoleOutPut(StringConstants.FILE_NOT_FOUND);
                result = false;
            }

            else if(!validator.CheckFileType(filePath, ".txt"))
            {
                UI.ConsoleOutPut(StringConstants.WRONG_FILE_TYPE);
                result = false;
            }

            else if (validator.IsFileEmpty(filePath))
            {
                UI.ConsoleOutPut(StringConstants.EMPTY_FILE);
                result = false;
            }

            return result;
        }

        private ProgramMode ChooseProgramMode(int arraySize)
        {
            if(arraySize == NUMBER_OF_ARGUMENTS_TO_SEARCH)
            {
                return ProgramMode.SearchPattern;
            }
            else
            {
                return ProgramMode.SearchPatternAndSwap;
            }
        }
    }
}
