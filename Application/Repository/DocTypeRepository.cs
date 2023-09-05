using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class DocTypeRepository : GenericRepository<DocType>, IDocTypeRepository
{
    public DocTypeRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}