using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface IRatingRepository
    {
        Task<IEnumerable<int>> GetAllRatingsAsync();
        Task<int?> GetRatingByIdAsync(Id ratingId);
        Task AddRatingAsync(int rating);
        Task UpdateRatingAsync(int rating);
        Task DeleteRatingAsync(int rating);
    }
}
