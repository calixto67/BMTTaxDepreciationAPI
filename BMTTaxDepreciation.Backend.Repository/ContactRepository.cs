using BMTTaxDepreciation.Backend.Repository.Generic_Repository;
using BMTTaxDepreciation.Backend.Repository.Interfaces;
using BMTTaxDepreciation.Backend.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMTTaxDepreciation.Backend.Repository
{
    public class ContactRepository : DBRepository<Contact>, IContactRepository
    {
        public ContactRepository(BMTContext bmtContext) : base(bmtContext) 
        {

        }

        public async Task<List<Contact>> GetContacts() {
            return await this.context.Contact.Where(m => m.IsDeleted == false)
                                             .ToListAsync();
        }
    }
}
