using Aon.MyAon.Common.Interface;
using Aon.MyAon.Persistence.Database;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aon.MyAon.IoC
{
    public class UserRepositoryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
        }
    }
}