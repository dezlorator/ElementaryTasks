using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class NumericalFibonacciSequenceCreator : IEnumerable<int>
    {

        #region private

        private readonly int minNumber;

        private readonly int maxNumber;

        private readonly int firstFibonacciNumber;

        private readonly int secondFibonacciNumber;

        #endregion

        public NumericalFibonacciSequenceCreator(int minNumber, int maxNumber)
        {
            this.minNumber = minNumber;
            this.maxNumber = maxNumber;
            firstFibonacciNumber = GetNearestFibonacciNumber(minNumber, out secondFibonacciNumber);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciSequenceEnumerator(minNumber, maxNumber, firstFibonacciNumber, secondFibonacciNumber);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FibonacciSequenceEnumerator(minNumber, maxNumber, firstFibonacciNumber, secondFibonacciNumber);
        }

        private int GetNearestFibonacciNumber(int minNumber, out int secondFibonacciNumber)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            while(firstNumber + secondNumber < minNumber)
            {
                secondNumber += firstNumber;
                firstNumber = secondNumber - firstNumber;
            }
            secondFibonacciNumber = secondNumber;

            return firstNumber;
        }
    }
}
