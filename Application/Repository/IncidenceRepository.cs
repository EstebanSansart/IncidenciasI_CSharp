using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class IncidenceRepository : GenericRepository<Incidence>, IIncidenceRepository
{
    private readonly ApiIncidenciasIContext _context;
    public IncidenceRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}