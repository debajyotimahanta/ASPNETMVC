using System;
using An.MyAon.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aon.MyAon.Web.Controllers;
using System.Web.Mvc;
using Aon.MyAon.Common.Interface;
using System.Collections.Generic;

namespace Aon.MyAon.Web.Tests
{
    [TestClass]
    public class UserControllerTest
    {
        

        [TestMethod]
        public void UserController_without_IoC()
        {
            IUserRepository userRepo = new Aon.MyAon.Persistence.TestRepository.UserRepository();
            UserController controller = new UserController(userRepo);
            ViewResult result = controller.Index() as ViewResult;
            List<User> users = result.ViewData.Model as List<User>;
            Assert.IsTrue(users.Count > 0);
        }

       
    }
}
