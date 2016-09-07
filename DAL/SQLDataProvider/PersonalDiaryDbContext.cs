using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.SQLDataProvider
{
    public class PersonalDiaryDbContext : DbContext
    {
        public PersonalDiaryDbContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
