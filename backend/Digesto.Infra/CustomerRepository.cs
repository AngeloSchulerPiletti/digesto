using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Infra;

public class CustomerRepository : ICustomerRepository
{
    private readonly DigestoContext _context;

    public CustomerRepository(DigestoContext context)
    {
        _context = context;
    }

    public Customer GetCustomer(uint id)
    {
        return _context.Customers.Find(id);
    }

    public Customer GetCustomerByEmail(string email)
    {
        return _context.Customers.FirstOrDefault(x => x.Email == email);
    }
}
