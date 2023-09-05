using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class ContactRepository : GenericRepository<Contact>, IContactRepository
{
    public ContactRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}