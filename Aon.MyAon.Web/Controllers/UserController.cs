using System.Threading;
using Aon.MyAon.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StackExchange.Profiling;

namespace Aon.MyAon.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepo;



        public UserController(IUserRepository userRepo)
        {
            
            _userRepo = userRepo;
        }
        //
        // GET: /User/
        public ActionResult Index()
        {
            var profiler = MiniProfiler.Current; // it's ok if this is null
            using (profiler.Step("Set page title"))
            {
                ViewBag.Title = "Home Page";
            }
            using (profiler.Step("Doing complex stuff"))
            {
                using (profiler.Step("Step A"))
                { // something more interesting here
                    Thread.Sleep(100);
                }
                using (profiler.Step("Step B"))
                { // and here
                    Thread.Sleep(250);
                }
            }
            var users = _userRepo.GetAllUsers();
            return View(users);
        }

    }
}
