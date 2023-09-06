using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class DocTypeRepository : GenericRepository<DocType>, IDocTypeRepository
{
    private readonly ApiIncidenciasIContext _context;
    public DocTypeRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}