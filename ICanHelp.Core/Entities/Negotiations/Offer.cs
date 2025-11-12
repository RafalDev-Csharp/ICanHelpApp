using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Negotiations
{
    public abstract class Offer
    {
        public Id Id { get; private set; }
        public Id AnnouncementId { get; set; }  
        public UserId ClientId { get; set; }
        public UserId HelperId { get; set; }
        public bool IsAvailable { get; set; }

        public CustomDateTime WantToStart { get; set; }
        public CustomDateTime WantToFinish { get; set; }
        public Price Price { get; set; }
        public Description Description { get; set; }
        public bool IsAcceptedByClient { get; set; }
        public bool IsAcceptedByHelper { get; set; }
        public bool CreatedByHelper { get; set; }

        protected Offer(Id id, Id announcementId, UserId clientId, UserId helperId, bool isAvailable, CustomDateTime wantToStart, CustomDateTime wantToFinish, Price price, Description description, bool isAcceptedByClient, bool isAcceptedByHelper)
        {
            Id = id;
            AnnouncementId = announcementId;
            ClientId = clientId;
            HelperId = helperId;
            IsAvailable = isAvailable;

            WantToStart = wantToStart;
            WantToFinish = wantToFinish;
            Price = price;
            Description = description;
            IsAcceptedByClient = isAcceptedByClient;
            IsAcceptedByHelper = isAcceptedByHelper;
        }
    }
}
