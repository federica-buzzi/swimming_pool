using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmin_pool_entities
{
    public class PlanningEntity
    {
        private string _scheduledDays, _extraInfo;
        private string _scheduledTimeStart, _scheduledTimeEnd;

        #region Props
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

        public string ScheduledTimeStart
        {
            get
            {
                return _scheduledTimeStart;
            }

            set
            {
                _scheduledTimeStart = value;
            }
        }

        public string ScheduledTimeEnd
        {
            get
            {
                return _scheduledTimeEnd;
            }

            set
            {
                _scheduledTimeEnd = value;
            }
        } 
        #endregion
    }
}
