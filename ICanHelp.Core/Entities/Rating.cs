using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class Rating
    {
        public Id Id { get; set; }
        public Id AnnouncementId { get; set; }
        public UserId UserId { get; set; }
        public Rate Rate { get; set; }

        protected Rating(Id id, Id announcementId, UserId userId, Rate rate)
        {
            Id = id;
            AnnouncementId = announcementId;
            UserId = userId;
            Rate = rate;
        }

        public void UpdateRate(Rate rate)
        {
            Rate = rate;
        }
    }
}
