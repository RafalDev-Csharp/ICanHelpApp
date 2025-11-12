using ICanHelp.Core.Entities.Negotiations;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class Announcement
    {
        public Id Id { get; set; }
        public UserId UserId { get; set; }
        public StringObject Title { get; set; }
        public CustomDateTime CreatedAt { get; set; }
        public Location Location { get; set; }
        public Description Description { get; set; }
        public Price Price { get; set; }
        //cate subcat DifficultLvl TimeToFix

        public ClientOffer ClientOffer { get; set; }
        public IEnumerable<HelperOffer> HelperOffers { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}
