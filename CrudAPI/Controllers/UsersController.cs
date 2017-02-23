using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.Helpers;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace CrudAPI.Controllers
{
    public class UsersController : ApiController
    {
        UserContext userContext = new UserContext();
        public UsersController()
        {
            
        }
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
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
