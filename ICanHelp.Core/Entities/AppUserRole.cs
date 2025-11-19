using ICanHelp.Core.Entities.Negotiations;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class AppUserRole
    {
        public Id Id { get; set; }
        public StringObject UserRoleName { get; set; }

        public IEnumerable<ClientOffer> ClientOffers { get; set; }
        public IEnumerable<HelperOffer> HelperOffers { get; set; }

        public AppUserRole(Id id, StringObject userRoleName)
        {
            Id = id;
            UserRoleName = userRoleName;
        }

        public void UpdateAppUserRole(StringObject userRoleName)
        {
            UserRoleName = userRoleName;
        }
    }
}
