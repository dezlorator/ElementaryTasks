using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class Ticket
    {
        #region private

        private byte[] TicketNumber;

        #endregion

        #region public

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
            TicketNumber = ConvertStringToByteArray(number);
        }

        private byte[] ConvertStringToByteArray(string source)
        {
            byte[] byteArrayOfTickets = new byte[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                byteArrayOfTickets[i] = byte.Parse(Convert.ToString(source[i]));
            }

            return byteArrayOfTickets;
        }

        public int GetLength()
        {
            return TicketNumber.Length;
        }

        public override string ToString()
        {
            StringBuilder ticketString = new StringBuilder();
            foreach(byte b in TicketNumber)
            {
                ticketString.Append(b);
            }

            return ticketString.ToString();
        }
    }
}
