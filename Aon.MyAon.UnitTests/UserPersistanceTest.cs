using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using An.MyAon.Common.Models;
using Aon.MyAon.Persistence.Database.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aon.MyAon.Common.Interface;

namespace Aon.MyAon.UnitTests
{
    [TestClass]
    public class UserPersistanceTest
    {
        [TestMethod]
        public void GetUser_by_id_using_test_repo()
        {
            IUserRepository userRepo = new Aon.MyAon.Persistence.TestRepository.UserRepository();
            User _user = userRepo.GetUserByid("aonus1\\9dmahant");
            Assert.IsNotNull(userRepo);
            Assert.AreEqual(_user.Name, "Debajyoti Mahanta");

        }
        [TestMethod]
        public void Get_all_users_from_test_repo()
        {
            IUserRepository userRepo = new Aon.MyAon.Persistence.TestRepository.UserRepository();
            var _users = userRepo.GetAllUsers();
            Assert.IsTrue(_users.Count > 0);
        }

        [TestMethod]
        public void Database_User_Creation_or_get_Test()
        {
            using (var db = new MyAonContext())
            {
                /*
                Aon.MyAon.Persistence.Database.User user = new Aon.MyAon.Persistence.Database.User() { Id = "aonus1\\9dmahant1", Name = "Debajyoti Mahanta" };
                db.Users.Add(user);
                db.SaveChanges();
                 */
                var userQuery=db.Users.Where(p => p.Id == "aonus1\\9dmahant");
                Assert.IsTrue(userQuery.Count()>0);



            }

           
        }

        [TestMethod]
        public void GetUserById_Test_Using_DB()
        {

            IUserRepository repo = new Aon.MyAon.Persistence.Database.UserRepository();
            var users = repo.GetAllUsers();
            Assert.IsTrue(users.Count>0);



        }
    }
}

