using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudAPI.DataLayer.Models;
using CrudAPI.Dto;

namespace CrudAPI.Helpers
{
    public class DtoModelHelper
    {
        public List<UserDto> UserDtoFromModel(List<User> users)
        {
            var returnDtoList = new List<UserDto>();

            foreach (var item in users)
            {
                var userDto = new UserDto {
                    ContactNumber = "0" + item.ContactNumber.ToString(),
                    FullName = item.FirstName + " " + item.LastName,
                    UserName = item.UserName
                };
                returnDtoList.Add(userDto);
            }

            return returnDtoList;
        }
    }
}