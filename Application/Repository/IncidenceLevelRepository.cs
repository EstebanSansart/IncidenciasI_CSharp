using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class IncidenceLevelRepository : GenericRepository<IncidenceLevel>, IIncidenceLevelRepository
{
    public IncidenceLevelRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}