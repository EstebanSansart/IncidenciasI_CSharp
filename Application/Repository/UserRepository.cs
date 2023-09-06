using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApiIncidenciasIContext _context;
    public UserRepository(ApiIncidenciasIContext context) : base(context)
    {
        _context = context;
    }
}