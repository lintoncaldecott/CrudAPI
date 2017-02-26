using System.Linq;
using System.Web.Http;
using CrudAPI.DataLayer.Models;
using CrudAPI.Helpers;
using Newtonsoft.Json;
using CrudAPI.Dto;
using CrudAPI.DataLayer.Interfaces;
using CrudAPI.DataLayer;
using System.Collections.Generic;

namespace CrudAPI.Controllers
{
    public class UsersController : ApiController
    {
        DtoModelHelper dtoHelper = new DtoModelHelper();
        IRepository<User> repository;
        public UsersController(UserRepository repository)
        {
            this.repository = repository;
        }
    // GET api/values
    public string Get()
        {
            var users = repository.List.Where(u => u.Status == true).ToList();
            var returnUsers = dtoHelper.UserDtoFromModel(users);

            return JsonConvert.SerializeObject(returnUsers);
        }

        // GET api/values/5
        public string Get(int id)
        {
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
            repository.Add(dtoHelper.UserModelFromDto(user));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]UserDto user)
        {
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
            var modelToDelete = repository.FindById(id);
            repository.Delete(modelToDelete);
        }
    }
}
