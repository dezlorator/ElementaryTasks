using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    class Validator
    {
        #region private

        private static int SIZE_OF_ARGUMENTS_ARRAY = 4;
        private static int SIZE_OF_SIDES_ARRAY = 3;

        #endregion
        //ВОПРОС: ПРАВИЛЬНО ЛИ ТУТ ИСПОЛЬЗОВАТЬ ИСКЛЮЧЕНИЯ И СТОИТ ЛИ ВСЕ СОБИРАТЬ В ОДИН МЕТОД?
        public Triangle GetValidatedTriangle(string UserInput)
        {
            if(UserInput == null || UserInput == "")
            {
                throw new ArgumentNullException("Argument shouldn`t be a null");
            }
            string[] parsedElements = UserInput.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            if (!IsRightNumberOfElements(parsedElements))
            {
                throw new IndexOutOfRangeException("Wrong number of arguments");
            }

            int[] sidesArray = new int[SIZE_OF_SIDES_ARRAY];
            for(int indexOfParsedArray = 1, IndexOfSidesArray = 0; IndexOfSidesArray < SIZE_OF_SIDES_ARRAY; indexOfParsedArray++, IndexOfSidesArray++)
            {
                if (!IsRightElementsType(parsedElements[indexOfParsedArray],out sidesArray[IndexOfSidesArray]))
                {
                    throw new FormatException("Wrong type of the triangle side");
                }
            }

            for(int i = 0; i < SIZE_OF_SIDES_ARRAY; i++)
            {
                if(!IsRightValue(sidesArray[i]))
                {
                    throw new ArgumentOutOfRangeException("Wrong value of the triangle side. It should be bigger than zero");
                }
            }

            return new Triangle(parsedElements[0], sidesArray[0], sidesArray[1], sidesArray[2]);
        }

        private bool IsRightNumberOfElements(string[] arrayToCheck)
        {
            return arrayToCheck.Length == SIZE_OF_ARGUMENTS_ARRAY;
        }

        private bool IsRightElementsType(string stringToCheck, out int parsedInt)
        {
            return Int32.TryParse(stringToCheck, out parsedInt);
        }

        private bool IsRightValue(int sideLenght)
        {
            return sideLenght > 0;
        }
    }
}
