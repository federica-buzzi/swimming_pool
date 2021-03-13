using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmin_pool_entities
{
    public class BookingFormEntity
    {
        private string _firstName, _lastName, _email, _telephone, _message;
        private int _spotsBooked;
        private DateTime _bookingDate;
        private string _bookingTime; 

        #region Props
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        public int SpotsBooked
        {
            get
            {
                return _spotsBooked;
            }

            set
            {
                _spotsBooked = value;
            }
        }

        public DateTime BookingDate
        {
            get
            {
                return _bookingDate;
            }

            set
            {
                _bookingDate = value;
            }
        }

        public string BookingTime
        {
            get
            {
                return _bookingTime;
            }

            set
            {
                _bookingTime = value;
            }
        }


        #endregion
    }
}
