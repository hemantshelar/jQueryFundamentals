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
        IGenericRepository<Address> AddressRepository { get;}
        IGenericRepository<UserInfo> UserInfoRepository { get; }
        void Save();
    }
}
