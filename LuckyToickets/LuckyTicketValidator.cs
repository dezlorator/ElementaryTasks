using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class LuckyTicketValidator : ILuckyTicketValidator
    {

        public bool IsRightAlgorithm(string algorithmName)
        {
            return (algorithmName.ToUpper() == "MOSKOW" || algorithmName.ToUpper() == "PITER");
        }
    }
}
