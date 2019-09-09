using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    class SequenceEnumerator : IEnumerator<int>
    {

        #region private

        private readonly int maxNumber;

        private int counter;

        #endregion

        #region property

        public int Current
        {
            get
            {
                return counter;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return counter;
            }
        }

        #endregion
        public SequenceEnumerator(int maxNumber)
        {
            this.maxNumber = maxNumber;
            counter = 0;
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(counter < maxNumber)
            {
                counter++;

                return true;
            }

            return false;
        }

        public void Reset()
        {
            counter = 0;
        }
    }
}
