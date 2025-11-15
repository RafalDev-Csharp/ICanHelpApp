using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface ILocationRepository
    {
        Task<IEnumerable<string>> GetAllLocationsAsync();
        Task<string?> GetLocationByIdAsync(Guid locationId);
        Task AddLocationAsync(string location);
        Task UpdateLocationAsync(string location);
        Task DeleteLocationAsync(string location);
    }
}
