using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    class PriceModel
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
