using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAPI.Dto
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
    }
}