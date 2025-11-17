using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Application.DTO
{
    public class AppUserRoleDto
    {
        public Guid Id { get; set; }
        public string UserRoleName { get; set; }
    }
}
