﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDiary.Domain.Enums
{
    public enum EnumGender
    {
        Male = 0 ,
        Female = 1,
        Other
    }

    public enum EnumNotificationType
    {
        Email = 0,
        SMS = 1,
        Call = 2,
    }

    public enum EnumUserExtendedStatus
    {
        New = 0,
        Active = 1,
        Blocked = 2,
        Special=3
    }
}
