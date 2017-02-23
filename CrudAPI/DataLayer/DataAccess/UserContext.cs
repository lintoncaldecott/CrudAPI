using CrudAPI.DataLayer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrudAPI.DataLayer.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserDb")
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}