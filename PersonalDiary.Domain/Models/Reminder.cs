using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDiary.Domain
{
    public class Reminder
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public bool RepeatDaily { get; set; }
        public bool RepeatWeekly { get; set; }
        public bool RepeatMonthly { get; set; }
        public bool RepeatYearly { get; set; }
        public DateTime RemindDateTime { get; set; }       
    }
}
