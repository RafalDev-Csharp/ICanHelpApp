using ICanHelp.Core.Entities.Liked;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface ILikedAnnouncementRepository
    {
        Task<IEnumerable<LikedAnnouncement>> GetAllLikedAnnouncementsAsync();
        Task<LikedAnnouncement?> GetLikedAnnouncementByIdAsync(Id likedAnnouncementId);
        Task AddLikedAnnouncementAsync(LikedAnnouncement likedAnnouncement);
        Task UpdateLikedAnnouncementAsync(LikedAnnouncement likedAnnouncement);
        Task DeleteLikedAnnouncementAsync(LikedAnnouncement likedAnnouncement);
    }
}
