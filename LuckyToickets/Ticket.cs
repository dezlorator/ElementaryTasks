using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class Ticket
    {
        #region public

        private byte[] TicketNumber;

        public bool IsLucky { get; set; }

        #endregion

        public byte this[int index]
        {
            get
            {
                if(index < TicketNumber.Length)
                {
                    return TicketNumber[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public Ticket(string number)
        {
            TicketNumber = ConvertStringToBoolArray(number);
        }

        private byte[] ConvertStringToBoolArray(string stringToConvert)
        {
            byte[] byteArrayOfTickets = new byte[stringToConvert.Length];
            for (int i = 0; i < stringToConvert.Length; i++)
            {
                byteArrayOfTickets[i] = byte.Parse(Convert.ToString(stringToConvert[i]));
            }

            return byteArrayOfTickets;
        }

        public int GetLength()
        {
            return TicketNumber.Length;
        }
    }
}
