using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class IncidenceDetailRepository : GenericRepository<IncidenceDetail>, IIncidenceDetailRepository
{
    public IncidenceDetailRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}