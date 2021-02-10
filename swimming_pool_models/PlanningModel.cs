using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_models
{
    public class PlanningModel
    {
        private string _scheduledDays, _extraInfo;
        private DateTime _scheduledTime;

        public string ScheduledDays
        {
            get
            {
                return _scheduledDays;
            }

            set
            {
                _scheduledDays = value;
            }
        }

        public string ExtraInfo
        {
            get
            {
                return _extraInfo;
            }

            set
            {
                _extraInfo = value;
            }
        }

        public DateTime ScheduledTime
        {
            get
            {
                return _scheduledTime;
            }

            set
            {
                _scheduledTime = value;
            }
        }
    }
}
