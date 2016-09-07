using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.SQLDataProvider;
using PersonalDiary.Domain;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTestUserInfo
    {
        //[TestMethod]
        public void TestMethodUserInfoAdd()
        {
            PersonalDiaryDbContext dbContext  = new PersonalDiaryDbContext();
            IGenericUnitOfWork sqlUoW = new SQLUnitOfWork(dbContext);

            UserInfo userInfo = new UserInfo
            {
                AspNetUsers_Id = 1,
                DOB = DateTime.Now,
                Gender = PersonalDiary.Domain.Enums.EnumGender.Male,
                Id = -1
            };
            sqlUoW.UserInfoRepository.Add(userInfo);

            Address addresss = new Address
            {
                Id = -1,
                StreetNo = 32,
                Street = "Rutherford St",
                City = "Blacktown",
                State = "NSW",
                Country = "Australia",
                UserInfoId = 1
            };

            sqlUoW.AddressRepository.Add(addresss);

            sqlUoW.Save();
            Assert.AreNotEqual(userInfo.Id, -1);
            Assert.AreNotEqual(addresss.Id, -1);
        }

        [TestMethod]
        public void TestMethodFilter()
        {
            PersonalDiaryDbContext dbContext = new PersonalDiaryDbContext();
            IGenericUnitOfWork sqlUoW = new SQLUnitOfWork(dbContext);
            IQueryable<Address> result = sqlUoW.AddressRepository.Filter(t => t.State.Contains("NSW"));
            Assert.IsNotNull(result);
            Assert.AreNotEqual(result.Count(), 0);
        }
    }
}
