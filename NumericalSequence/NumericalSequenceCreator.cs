using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    class NumericalSequenceCreator : IEnumerable<int>
    {

        #region private

        private readonly int maxNumber;

        #endregion

        public NumericalSequenceCreator(int maxNumber)
        {
            this.maxNumber = GetSqrt(maxNumber);
        }

        public int GetSqrt(int value)
        {
            int counter = (int)Math.Sqrt(value);
            if(Math.Pow(counter, 2) == value)
            {
                counter--;
            }

            return counter;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SequenceEnumerator(maxNumber);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SequenceEnumerator(maxNumber);
        }
    }
}
