using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Negotiations
{
    public class Offer
    {
        public Id Id { get; set; }
        public Id AnnouncementId { get; set; }  
        public UserId ClientId { get; set; }
        public UserId HelperId { get; set; }
        public bool IsCompleted { get; set; }
    }
}
