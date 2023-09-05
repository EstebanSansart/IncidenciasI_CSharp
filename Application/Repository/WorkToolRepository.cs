using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class WorkToolRepository : GenericRepository<WorkTool>, IWorkToolRepository
{
    public WorkToolRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}