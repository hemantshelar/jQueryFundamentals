using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDiary.Domain.Enums;

namespace PersonalDiary.Domain
{
    public class Notification : IDbEntity
    {
        public int Id { get; set; }
        public EnumNotificationType EnumNotificationType { get; set; }
        public string NotificationDetails { get; set; }
        public int ReminderId { get; set; }
        public Reminder Reminder { get; set; }
    }
}
