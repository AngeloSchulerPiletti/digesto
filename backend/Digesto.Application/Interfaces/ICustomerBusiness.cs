using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;

namespace Digesto.Application.Interfaces;

public interface ICustomerBusiness
{
    public MessageBagSingleEntityVO<Customer> GetCustomer(uint id);
    public MessageBagSingleEntityVO<Customer> GetCustomerByEmail(string email);
}
