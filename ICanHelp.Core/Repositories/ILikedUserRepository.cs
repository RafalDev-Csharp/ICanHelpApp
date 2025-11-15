using ICanHelp.Core.Entities.Liked;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface ILikedUserRepository
    {
        Task<IEnumerable<LikedUser>> GetAllLikedUsersAsync();
        Task<LikedUser?> GetLikedUserByIdAsync(Id likedUserId);
        Task AddLikedUserAsync(LikedUser likedUser);
        Task UpdateLikedUserAsync(LikedUser likedUser);
        Task DeleteLikedUserAsync(LikedUser likedUser);
    }
}
