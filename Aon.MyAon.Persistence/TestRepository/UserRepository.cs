using An.MyAon.Common.Models;
using Aon.MyAon.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aon.MyAon.Persistence.TestRepository
{
    public class UserRepository:IUserRepository
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
            _users.Add(new User {Name="Debajyoti Mahanta",UserId="aonus1\\9dmahant" });
            _users.Add(new User { Name = "D Mahanta", UserId = "aonus1\\9dmahantD" });
            _users.Add(new User { Name = "X Mahanta", UserId = "aonus1\\9dmahantX" });
        }


        public User GetUserByid(string id)
        {
            return _users.Find(p => p.UserId == id);
        }




        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
