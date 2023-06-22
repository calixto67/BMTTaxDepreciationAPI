using BMTTaxDepreciation.Backend.Repository.Generic_Repository;
using BMTTaxDepreciation.Backend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BMTTaxDepreciation.Backend.Repository.Interfaces
{
    public interface IContactRepository : IDbRepository<Contact>
    {
        Task<List<Contact>> GetContacts();

    }
}
