using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EnvelopeComparison;

namespace EnvelopeComparisonTests
{
    public class EnvelopeComparerTest
    {
        [Theory]
        [InlineData (18.5, 17.4, 13.0, 17.0, EnvelopeCompareStages.SecondIntoFirst)]
        [InlineData(18.5, 17.4, 20.4, 19.0, EnvelopeCompareStages.FirstIntoSecond)]
        [InlineData(20.0, 28.5, 21.6, 18.7, EnvelopeCompareStages.SecondIntoFirst)]
        [InlineData(20.0, 20.0, 20.0, 20.0, EnvelopeCompareStages.SecondIntoFirst)]
        public void EnvelopeComparerTests(double firstHeight, double firstWidth, 
        double secondHeigh, double secondWidth, EnvelopeCompareStages expected)
        {
            Envelope first = new Envelope(firstHeight, firstWidth);
            Envelope second = new Envelope(secondHeigh, secondWidth);

            EnvelopeComparer comparer = new EnvelopeComparer();
            Assert.Equal(comparer.CompareEnvelops(first, second), expected);
        }
    }
}
