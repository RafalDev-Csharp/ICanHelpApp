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
        public Guid UserId { get; set; }
        public double Rate { get; set; }
    }
}
