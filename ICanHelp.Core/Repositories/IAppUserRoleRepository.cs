using ICanHelp.Core.Entities;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface IAppUserRoleRepository
    {
        Task<IEnumerable<AppUserRole>> GetAllAppUserRolesAsync();
        Task<AppUserRole?> GetAppUserRoleByIdAsync(Id appUserRoleId);
        Task AddAppUserRoleAsync(AppUserRole appUserRole);
        Task UpdateAppUserRoleAsync(AppUserRole appUserRole);
        Task DeleteAppUserRoleAsync(AppUserRole appUserRole);
    }
}
