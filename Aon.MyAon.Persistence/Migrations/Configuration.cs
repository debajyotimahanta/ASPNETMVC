using System.Collections.Generic;
using Aon.MyAon.Persistence.Database;

namespace Aon.MyAon.Persistence.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Aon.MyAon.Persistence.Database.Context.MyAonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Aon.MyAon.Persistence.Database.Context.MyAonContext context)
        {
            /*
            List<User> users = new List<User>
            {
                new User {Id = "aonus1\\9dmahant", Name = "Debajyoti Mahanta"},
                new User {Id = "aonus1\\dsulliv", Name = "Dave Silliuvan"},
                new User {Id = "aonus1\\jwittie", Name = "James Wittie"}

            };

            users.ForEach(s => context.Users.AddOrUpdate(p => p.Id, s));
            context.SaveChanges()
             * */
        }
    }
}
