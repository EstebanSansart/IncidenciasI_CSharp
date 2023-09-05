using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class UserAreaRepository : GenericRepository<UserArea>, IUserAreaRepository
{
    public UserAreaRepository(ApiIncidenciasIContext context) : base(context)
    {
    }
}