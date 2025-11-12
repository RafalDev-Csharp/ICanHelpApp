using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Liked
{
    public class LikedAnnouncement : Liked
    {
        public Id AnnouncementId { get; set; }
    
        public LikedAnnouncement(Id id, Id announcementId, bool isLiked) : base(id, isLiked)
        { 
            AnnouncementId = announcementId;
        }
    }

}
