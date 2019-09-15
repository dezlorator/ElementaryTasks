using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
    public interface IEnvelopeComparer
    {
        EnvelopeCompareStages CompareEnvelops(Envelope first, Envelope second);
    }
}
