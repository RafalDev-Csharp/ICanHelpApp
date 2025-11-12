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
        public CustomDateTime WantToStart { get; set; }
        public CustomDateTime WantToFinish { get; set; }
        public Price Price { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
    }
}
