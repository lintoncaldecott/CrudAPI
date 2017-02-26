using System.Linq;
using System.Web.Http;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.DataLayer.Models;
using CrudAPI.Helpers;
using Newtonsoft.Json;
using CrudAPI.Dto;
using System.Data.Entity;
using CrudAPI.DataLayer.Interfaces;
using CrudAPI.DataLayer;
using System.Collections.Generic;

namespace CrudAPI.Controllers
{
    public class UsersController : ApiController
    {
        IRepository<User> repository;
        public UsersController(UserRepository repository)
        {
            this.repository = repository;
        }
    // GET api/values
    public string Get()
        {
            var dtoHelper = new DtoModelHelper();
            var users = repository.List.Where(u => u.Status == true).ToList();
            var returnUsers = dtoHelper.UserDtoFromModel(users);

            return JsonConvert.SerializeObject(returnUsers);
        }

        // GET api/values/5
        public string Get(int id)
        {
            var dtoHelper = new DtoModelHelper();
            List<User> user = new List<User> { repository.FindById(id) };
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
            repository.Add(dtoHelper.UserModelFromDto(user));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]UserDto user)
        {
            var dtoHelper = new DtoModelHelper();
            User userModel = repository.FindById(user.UserId);
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.UserName = user.UserName;
            userModel.Status = true;
            userModel.ContactNumber = int.Parse(user.ContactNumber);
            repository.Update(userModel);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
