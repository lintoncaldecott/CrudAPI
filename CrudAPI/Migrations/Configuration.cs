using System.Data.Entity.Migrations;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.DataLayer.Models;
using System.Collections.Generic;

namespace CrudAPI.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User {FirstName="Rick", LastName="Deckard", ContactNumber=794567894, Status=true, UserName="RickDeckard@gmail.com"},
                new User {FirstName="Roy", LastName="Batty", ContactNumber=794567895,  Status=true, UserName="RoyBatty@gmail.com"},
                new User {FirstName="Jessica", LastName="Atreides", ContactNumber=794567896,  Status=true, UserName="JessicaAtreides@gmail.com"},
                new User {FirstName="Paul", LastName="Atreides", ContactNumber=794567897,  Status=true, UserName="MuadDib@gmail.com"},
                new User {FirstName="Duncan", LastName="Idaho", ContactNumber=794567896,  Status=true, UserName="SwordmasterIdaho@gmail.com"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}
