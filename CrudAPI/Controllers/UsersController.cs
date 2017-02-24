using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.DataLayer.Models;
using CrudAPI.Helpers;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using CrudAPI.Dto;
using System.Data.Entity;

namespace CrudAPI.Controllers
{
    public class UsersController : ApiController
    {
        UserContext userContext = new UserContext();

        // GET api/values
        public string Get()
        {
            var dtoHelper = new DtoModelHelper();
            var users = userContext.Users.Where(u => u.Status == true).ToList();
            var returnUsers = dtoHelper.UserDtoFromModel(users);

            return JsonConvert.SerializeObject(returnUsers);
        }

        // GET api/values/5
        public string Get(int id)
        {
            var dtoHelper = new DtoModelHelper();
            var user = userContext.Users.Where(u => u.UserId == id).ToList();
            var returnUser = dtoHelper.UserDtoFromModel(user);
            if (returnUser != null)
            {
                return JsonConvert.SerializeObject(returnUser[0]);
            }
            else
            {
                return null;
            }
        }

        // POST api/values
        public void Post([FromBody]UserDto user)
        {
            var dtoHelper = new DtoModelHelper();
            
            User userModel = userContext.Users.Add(dtoHelper.UserModelFromDto(user));
            userContext.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]UserDto user)
        {
            var dtoHelper = new DtoModelHelper();
            User userModel = userContext.Users.Where(u => u.UserId == user.UserId).First();
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.UserName = user.UserName;
            userModel.ContactNumber = int.Parse(user.ContactNumber);
            userContext.Entry(userModel).State = EntityState.Modified;
            userContext.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
