using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aon.MyAon.Common.Interface;
using Aon.MyAon.Persistence.Database.Context;
using AutoMapper;

namespace Aon.MyAon.Persistence.Database
{
    public class UserRepository:IUserRepository
    {
        public An.MyAon.Common.Models.User GetUserByid(string id)
        {
            throw new NotImplementedException();
        }

        public List<An.MyAon.Common.Models.User> GetAllUsers()
        {
            using (var db = new MyAonContext())
            
            {
                //TODO:use autom mapper or remove auto mapper
                /*
                Mapper.CreateMap<User, An.MyAon.Common.Models.User>();

                var users = db.Users.ToList();
                List<An.MyAon.Common.Models.User> usersDomain = Mapper.Map<List<User>,List<An.MyAon.Common.Models.User>>(users);
                return usersDomain;
                 */
                var usersDto = db.Users.ToList();

                return usersDto.Select(user => new An.MyAon.Common.Models.User() {UserId = user.Id, Name = user.Name}).ToList();

            }
        }
    }
}
