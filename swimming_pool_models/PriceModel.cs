using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    public class PriceModel
    {
        private string _ticketType;
        private double _ticketPrice;

        #region Props
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

        public double TicketPrice
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
        #endregion
    }
}
