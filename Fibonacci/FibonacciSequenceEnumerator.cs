using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciSequenceEnumerator : IEnumerator<int>
    {

        #region private

        private int firstFibonacciNumber;

        private int secondFibonacciNumber;

        #region readonly

        private readonly int minNumber;

        private readonly int maxNumber;

        private readonly int beginPoint;

        private readonly int savedFirstFibonacciNumber;

        private readonly int savedSecondFibonacciNumber;

        #endregion

        #endregion

        #region property

        public int Current { get; private set; }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        #endregion

        public FibonacciSequenceEnumerator(int minNumber, int maxNumber, int firstFibonacciNumber, int secondFibonacciNumber)
        {
            this.minNumber = minNumber;
            this.maxNumber = maxNumber;
            this.firstFibonacciNumber = firstFibonacciNumber;
            this.secondFibonacciNumber = secondFibonacciNumber;

            savedFirstFibonacciNumber = firstFibonacciNumber;
            savedSecondFibonacciNumber = secondFibonacciNumber;
            beginPoint = secondFibonacciNumber;
            Current = secondFibonacciNumber;

        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(firstFibonacciNumber + secondFibonacciNumber <= maxNumber)
            {
                secondFibonacciNumber += firstFibonacciNumber;
                firstFibonacciNumber = secondFibonacciNumber - firstFibonacciNumber;
                Current = secondFibonacciNumber;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Current = beginPoint;
            secondFibonacciNumber = savedSecondFibonacciNumber;
            firstFibonacciNumber = savedFirstFibonacciNumber;
        }

    }
}
