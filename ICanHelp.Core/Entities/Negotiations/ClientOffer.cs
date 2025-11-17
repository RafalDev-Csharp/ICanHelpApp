using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Negotiations
{
    public class ClientOffer : Offer
    {
        public Rating RateHelper { get; set; }

        public ClientOffer(Id id, Id announcementId, UserId clientId, UserId helperId,
            CustomDateTime wantToStart, CustomDateTime wantToFinish, Price price,
            Description description, bool isAccepted, AppUserRole acceptedBy, AppUserRole createdBy,
            Rating rateHelper)
                : base(id, announcementId, clientId, helperId, wantToStart,
                      wantToFinish, price, description, isAccepted, acceptedBy, createdBy)
        {
            RateHelper = rateHelper;
        }

        public void UpdateClientOffer(CustomDateTime wantToStart, CustomDateTime wantToFinish,
            Price price, Description description, bool isAccepted, Rating rateHelper)
        {
            WantToStart = wantToStart;
            WantToFinish = wantToFinish;
            Price = price;
            Description = description;
            IsAccepted = isAccepted;
            RateHelper = rateHelper;
        }
    }
}
