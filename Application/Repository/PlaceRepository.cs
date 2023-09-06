using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
{
    private readonly ApiIncidenciasIContext _context;
    public PlaceRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}