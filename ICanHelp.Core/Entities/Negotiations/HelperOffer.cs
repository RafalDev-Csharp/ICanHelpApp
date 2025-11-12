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
        public HelperOffer(Id id, Id announcementId, UserId clientId, UserId helperId, bool isAvailable,
            CustomDateTime wantToStart, CustomDateTime wantToFinish, Price price, Description description,
            bool isAccepted, bool isAcceptedByClient, bool isAcceptedByHelper)
                : base(id, announcementId, clientId, helperId, isAvailable, wantToStart,
                      wantToFinish, price, description, isAcceptedByHelper, isAcceptedByClient)
        {
        }
    }
}
