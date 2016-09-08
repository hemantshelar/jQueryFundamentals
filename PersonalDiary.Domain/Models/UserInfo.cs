using PersonalDiary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDiary.Domain
{
    public class UserInfo : IDbEntity
    {
        public int Id { get; set; }
        public string AspNetUsers_Id { get; set; }
        public EnumGender Gender { get; set; }
        public EnumUserExtendedStatus UserExtendedStatus { get; set; }
        public DateTime? DOB { get; set; }
    }
}
