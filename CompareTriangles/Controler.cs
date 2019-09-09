using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    class Controler
    {

        #region private

        private SortedSetOfTriangles triangleSortedSet;

        private Triangle newTriangle;

        private Validator validate;

        private string userChooseAboutContinue;

        #endregion

        public Controler()
        {
            triangleSortedSet = new SortedSetOfTriangles();
            newTriangle = new Triangle("", 0, 0, 0);
            validate = new Validator();
        }

        public void Run()
        {
            ClientUI.ConsoleOutPut(StringConstants.WELCOME_STRING);
            do
            {
                if (CheckInputValues(ClientUI.UserInput(), out newTriangle))
                {
                    triangleSortedSet.AddTriangle(newTriangle);
                    ClientUI.OutputResult(triangleSortedSet);
                    userChooseAboutContinue = ClientUI.AskIfUserWantToContinue();
                }
                else
                {
                    userChooseAboutContinue = "y";
                }
            }
            while (CheckUserOpinionAboutContinue(userChooseAboutContinue));
        }

        private bool CheckInputValues(string userInput, out Triangle triangle)
        {
            bool checkResult = true;
            try
            {
                triangle = validate.GetValidatedTriangle(userInput);
            }
            catch (ArgumentNullException)
            {
                ClientUI.ConsoleOutPut(StringConstants.WRITTEN_NOTHING);
                checkResult = false;
                triangle = null;
            }
            catch (IndexOutOfRangeException)
            {
                ClientUI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);
                checkResult = false;
                triangle = null;
            }
            catch (FormatException)
            {
                ClientUI.ConsoleOutPut(StringConstants.WRONG_TYPE_OF_SIDE);
                checkResult = false;
                triangle = null;
            }
            catch (ArgumentOutOfRangeException)
            {
                ClientUI.ConsoleOutPut(StringConstants.WRONG_VALUE_OF_SIDE);
                checkResult = false;
                triangle = null;
            }

            return checkResult;
        }

        private bool CheckUserOpinionAboutContinue(string userChoose)
        {
            return (userChoose.ToUpper() == "Y") || (userChoose.ToUpper() == "YES");
        }
    }
}
