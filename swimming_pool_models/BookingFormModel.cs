using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    public class BookingFormModel
    {
        private string _firstName, _lastName, _email, _telephone, _message;
        private int _spotsBooked;
        private DateTime _bookingDate;
        private string _bookingTime;


        #region Props
        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(323)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
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


        [Required]
        [MaxLength(12)]
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

        [Required]
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

        [Required]
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

        [Required]
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
