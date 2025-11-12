using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Liked
{
    public abstract class Liked
    {
        public Id Id { get; private set; }
        public bool IsLiked { get; set; }

        protected Liked(Id id, bool isLiked)
        {
            id = Id;
            IsLiked = isLiked;
        }
    }
}
