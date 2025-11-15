using ICanHelp.Core.Entities.Liked;
using ICanHelp.Core.Entities.Users;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Repositories
{
    public interface IContactData
    {
        //Task<IEnumerable<string>> GetAllContactDataAsync();
        Task AddContactDataAsync(string contactData);
        Task DeleteContactDataAsync(string contactData);

        Task<IEnumerable<ContactData>> GetAllContactDataAsync();
        Task<ContactData?> GetContactDataByIdAsync(Id contactData);
        Task AddContactDataAsync(ContactData contactData);
        Task UpdateContactDataAsync(ContactData contactData);
        Task DeleteContactDataAsync(ContactData contactData);
    }
}
