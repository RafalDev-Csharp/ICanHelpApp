using ICanHelp.Core.Entities;
using ICanHelp.Core.Entities.Users;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Application.DTO
{
    public class RatingDto
    {
        public Guid Id { get; set; }

        public Guid AnnouncementId { get; set; }
        public AnnouncementDto Announcement { get; set; }

        public Guid UserId { get; set; }
        public UserDto User { get; set; }

        public Guid RatedUserId { get; set; }
        public UserDto RatedUser { get; set; }

        public double Rate { get; set; }
    }
}
