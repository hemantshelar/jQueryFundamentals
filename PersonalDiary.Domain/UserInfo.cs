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
        public int AspNetUsers_Id { get; set; }       
    }
}
