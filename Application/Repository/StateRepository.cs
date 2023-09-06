using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class StateRepository : GenericRepository<State>, IStateRepository
{
    private readonly ApiIncidenciasIContext _context;
    public StateRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}