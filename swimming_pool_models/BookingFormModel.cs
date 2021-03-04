using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    public class BookingFormModel
    {
        string _firstName, _lastName, _email, _telephone, _message;
        int _spotsBooked;
        DateTime _datetime;

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

        public DateTime Datetime
        {
            get
            {
                return _datetime;
            }

            set
            {
                _datetime = value;
            }
        } 
        #endregion
    }
}
