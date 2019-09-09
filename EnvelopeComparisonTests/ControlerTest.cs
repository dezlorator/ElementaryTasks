using EnvelopeComparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Reflection;
using NLog;

namespace EnvelopeComparisonTests
{
    public class ControlerTest
    {
        [Theory]
        [InlineData ("oaommmm", false)]
        [InlineData("YeS", true)]
        [InlineData("OH WAIT", false)]
        [InlineData("Y", false)]
        public void ContinueOrNotTest(string userChoose, bool expected)
        {
            Type type = typeof(Controler);
            IUserUI UI = new UI();
            var hello = Activator.CreateInstance(type, UI);
            MethodInfo method = type.GetMethods(BindingFlags.NonPublic | 
            BindingFlags.Instance).Where(x => x.Name == "ContinueOrNot" && x.IsPrivate).First();
            Action.Equals((bool)method.Invoke(hello, new object[] { userChoose }), expected);
        }

        [Theory]
        [InlineData (new string[] {"35,2", "23", "ogogo" }, false)]
        [InlineData(new string[] { "35,2", "82"}, true)]
        [InlineData(new string[] { "12", "81"}, true)]
        [InlineData(new string[] { "35,2", "ogogo" }, false)]
        public void CheckCommandArguments(string[] commandArgumenrs, bool expected)
        {
            Type type = typeof(Controler);
            IUserUI UI = new UI();
            var hello = Activator.CreateInstance(type, UI);
            MethodInfo method = type.GetMethods(BindingFlags.NonPublic |
            BindingFlags.Instance).Where(x => x.Name == "CheckCommandArguments" && x.IsPrivate).First();
            Action.Equals((bool)method.Invoke(hello, new object[] { commandArgumenrs }), expected);
        }
    }
}
