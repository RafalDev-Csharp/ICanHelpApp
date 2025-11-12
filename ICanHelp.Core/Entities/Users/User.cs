using ICanHelp.Core.Entities.Users;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Offers
{
    public class User
    {
        public UserId Id { get; private set; }
        public UserName UserName { get; private set; }
        public Password Password { get; private set; }
        public FullName FullName { get; private set; }
        public Role Role { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsLocked { get; private set; }
        public Description Description { get; private set; }

        public ContactData ContactData { get; private set; }

        public IEnumerable<Announcement> Announcements { get; set; }
        public IEnumerable<Liked> Likeds { get; set; }
    }
}
