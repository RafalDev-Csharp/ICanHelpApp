using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Negotiations
{
    public class HelperOffer : Offer
    {
        public Rating RateClient { get; set; }
        public bool IsAccepted { get; set; }
        public HelperOffer(Id id, Id announcementId, UserId clientId, UserId helperId,
            CustomDateTime wantToStart, CustomDateTime wantToFinish, Price price, Description description,
            bool isAccepted, AppUserRole acceptedBy, AppUserRole createdBy,
            Rating rateClient)
                : base(id, announcementId, clientId, helperId, wantToStart,
                      wantToFinish, price, description, acceptedBy, createdBy)
        {
            RateClient = rateClient;
            IsAccepted = isAccepted;
        }

        public void UpdateHelperOffer(CustomDateTime wantToStart, CustomDateTime wantToFinish,
            Price price, Description description, bool isAccepted, Rating rateClient)
        {
            WantToStart = wantToStart;
            WantToFinish = wantToFinish;
            Price = price;
            Description = description;
            IsAccepted = isAccepted;
            RateClient = rateClient;
        }
    }
}
