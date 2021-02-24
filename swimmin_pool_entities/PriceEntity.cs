using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmin_pool_entities
{
    public class PriceEntity
    {
        private string _ticketType;
        private int _ticketPrice;

        public string TicketType
        {
            get
            {
                return _ticketType;
            }

            set
            {
                _ticketType = value;
            }
        }

        public int TicketPrice
        {
            get
            {
                return _ticketPrice;
            }

            set
            {
                _ticketPrice = value;
            }
        }
    }
}
