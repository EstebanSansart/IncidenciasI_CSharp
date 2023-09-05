using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class IncidenceTypeRepository : GenericRepository<IncidenceType>, IIncidenceTypeRepository
{
    public IncidenceTypeRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}