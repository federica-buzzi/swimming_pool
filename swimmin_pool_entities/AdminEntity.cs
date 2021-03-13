using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmin_pool_entities
{
    public class AdminEntity
    {
        private string _adminName, _adminPassword;

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
