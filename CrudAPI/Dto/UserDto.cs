using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAPI.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
    }
}