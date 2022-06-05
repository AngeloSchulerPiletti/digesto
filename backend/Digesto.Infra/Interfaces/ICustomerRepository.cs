using Digesto.Domain.Entities;

namespace Digesto.Infra.Interfaces;

public interface ICustomerRepository
{
    public Customer GetCustomer(uint id);
    public Customer GetCustomerByEmail(string email);
}
