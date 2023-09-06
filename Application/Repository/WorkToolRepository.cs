using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class WorkToolRepository : GenericRepository<WorkTool>, IWorkToolRepository
{
    private readonly ApiIncidenciasIContext _context;
    public WorkToolRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}