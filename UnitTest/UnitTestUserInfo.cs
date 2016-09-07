using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.SQLDataProvider;
using PersonalDiary.Domain;

namespace UnitTest
{
    [TestClass]
    public class UnitTestUserInfo
    {
        [TestMethod]
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
            sqlUoW.Save();
            Assert.AreNotEqual(userInfo.Id, -1);
        }
    }
}
