using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDiary.Domain;

namespace DAL.SQLDataProvider
{
    public class SQLUnitOfWork : IGenericUnitOfWork
    {
        private PersonalDiaryDbContext _dbContext;

        private IGenericRepository<UserInfo> _userInfoRepository = null;
        private IGenericRepository<Address> _addressRepository = null;

        public SQLUnitOfWork(PersonalDiaryDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public IGenericRepository<UserInfo> UserInfoRepository { get; set; }

        IGenericRepository<Address> IGenericUnitOfWork.AddressRepository
        {
            get 
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new GenericRepositorySQLImpl<Address>(_dbContext);                    
                }
                return _addressRepository;
            }
        }

        IGenericRepository<UserInfo> IGenericUnitOfWork.UserInfoRepository
        {
            get 
            {
                if (_userInfoRepository == null)
                {
                    _userInfoRepository = new GenericRepositorySQLImpl<UserInfo>(_dbContext);
                }
                return _userInfoRepository;
            }
        }

        void IGenericUnitOfWork.Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
