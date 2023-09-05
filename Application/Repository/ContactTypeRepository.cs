using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class ContactTypeRepository : GenericRepository<ContactType>, IContactTypeRepository
{
    public ContactTypeRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}