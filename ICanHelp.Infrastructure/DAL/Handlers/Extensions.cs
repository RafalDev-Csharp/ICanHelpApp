using ICanHelp.Application.DTO;
using ICanHelp.Core.Entities;
using ICanHelp.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Infrastructure.DAL.Handlers
{
    internal static class Extensions
    {

        public static UserDto AsDto(this User entity)
            => new()
            {
                Id = entity.Id,
                UserName = entity.UserName,
                FullName = entity.FullName,
                Role = new AppUserRoleDto
                {
                    //Id = Guid.Empty,
                    Id = entity.Id,
                    UserRoleName = entity.Role?.ToString() ?? string.Empty
                },

            };

        public static AppUserRoleDto AsDto(this AppUserRole entity)
            => new()
            {
                Id = entity.Id,
                UserRoleName = entity.UserRoleName.Value
            };

    }
}
