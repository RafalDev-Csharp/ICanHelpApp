using ICanHelp.Core.Entities.Offers;
using ICanHelp.Core.Entities.Ratings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Users
{
    public sealed class HelperUser : User
    {
        public HelperRating HelperRating { get; set; }
        
    }
}
