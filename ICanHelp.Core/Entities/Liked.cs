using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class Liked
    {
        public Id Id { get; set; }
        public Id AnnouncementId { get; set; }
        public bool IsLiked { get; set; }
    }
}
