using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Liked
{
    public class LikedUser : Liked
    {
        public UserId UserId { get; set; }

        public LikedUser(Id id, UserId userId, bool isLiked) : base(id, isLiked)
        {
            UserId = userId;    
        }
    }
}
