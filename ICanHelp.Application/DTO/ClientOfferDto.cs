using ICanHelp.Core.Entities;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Application.DTO
{
    public class ClientOfferDto
    {
        public Guid Id { get; private set; }
        public Guid AnnouncementId { get; set; }
        public Guid ClientId { get; set; }
        public Guid HelperId { get; set; }

        public DateTime WantToStart { get; set; }
        public DateTime WantToFinish { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public AppUserRoleDto AcceptedBy { get; set; }
        public AppUserRoleDto CreatedBy { get; set; }

        public RatingDto RateClient { get; set; }
        public bool IsAccepted { get; set; }
    }
}
