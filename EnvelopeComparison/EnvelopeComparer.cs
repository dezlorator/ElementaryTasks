using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
    class EnvelopeComparer : IEnvelopeComparer
    {
        public EnvelopeCompareStages CompareEnvelops(Envelope first, Envelope second)
        {
            if (CkechOpportunityOfPut(first, second))
            {
                return EnvelopeCompareStages.SecondIntoFirst;
            }
            else if (CkechOpportunityOfPut(second, first))
            {
                return EnvelopeCompareStages.FirstIntoSecond;
            }
            else
            {
                return EnvelopeCompareStages.DefaultValue;
            }

        }

        private bool CkechOpportunityOfPut(Envelope firthEnvelope, Envelope secondEnvelope)
        {
            return ((firthEnvelope.Height >= secondEnvelope.Height) && (firthEnvelope.Width >= secondEnvelope.Width)) ||
                   ((firthEnvelope.Height >= secondEnvelope.Width) && (firthEnvelope.Width >= secondEnvelope.Height));
        }
    }
}
