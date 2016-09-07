using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDiary.Domain;

namespace PersonalDiary.Domain
{
    public interface IGenericUnitOfWork
    {
        IGnericRepository<Address> AddressRepository { get;}
        IGnericRepository<UserInfo> UserInfoRepository { get; }
        void Save();
    }
}
