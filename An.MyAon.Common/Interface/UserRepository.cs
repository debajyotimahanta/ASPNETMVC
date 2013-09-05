using System;
using System.Collections.Generic;
using An.MyAon.Common.Models;


namespace Aon.MyAon.Common.Interface
{
    public interface IUserRepository
    {
        User GetUserByid(string id);
        List<User> GetAllUsers();
    }
}
