using System.Collections.Generic;
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
                    UserId = item.UserId,
                    ContactNumber = "0" + item.ContactNumber.ToString(),
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    UserName = item.UserName
                };
                returnDtoList.Add(userDto);
            }

            return returnDtoList;
        }

        public User UserModelFromDto(UserDto userDto)
        {
            return new User
            {
                UserId = userDto.UserId,
                ContactNumber = int.Parse(userDto.ContactNumber),
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserName = userDto.UserName
            };
        }
    }
}