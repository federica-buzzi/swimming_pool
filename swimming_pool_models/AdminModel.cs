using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    public class AdminModel
    {
        private string _adminName, _adminPassword;

        [Required]
        public string AdminName
        {
            get
            {
                return _adminName;
            }

            set
            {
                _adminName = value;
            }
        }

        [Required]
        public string AdminPassword
        {
            get
            {
                return _adminPassword;
            }

            set
            {
                _adminPassword = value;
            }
        }
    }
}
