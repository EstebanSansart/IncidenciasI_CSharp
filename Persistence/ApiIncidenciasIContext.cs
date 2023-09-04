using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class ApiIncidenciasIContext : DbContext
{
    public ApiIncidenciasIContext(DbContextOptions<ApiIncidenciasIContext> options) : base(options)
    {
    }
}