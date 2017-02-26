using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudAPI.DataLayer.Interfaces;
using CrudAPI.DataLayer.Models;
using CrudAPI.DataLayer.DataAccess;

namespace CrudAPI.DataLayer
{
    public class UserRepository : IRepository<User>
    {
        UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;

        }
        public IEnumerable<User> List
        {
            get
            {
                return _userContext.Users;
            }
        }

        public void Add(User entity)
        {
            entity.Status = true;
            _userContext.Users.Add(entity);
            _userContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.FindById(id);
            entity.Status = false;
            this.Update(entity);
        }

        public void Update(User entity)
        {
            _userContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _userContext.SaveChanges();
        }

        public User FindById(int Id)
        {
            var result = (from r in _userContext.Users where r.UserId == Id select r).FirstOrDefault();
            return result;
        }
    }
}