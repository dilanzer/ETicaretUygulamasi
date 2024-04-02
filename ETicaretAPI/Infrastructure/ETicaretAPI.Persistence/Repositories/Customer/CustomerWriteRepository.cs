using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustormerWriteRepository
{
    public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}