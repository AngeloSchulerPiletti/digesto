using Digesto.Application.Interfaces;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Application;

public class CustomerBusiness : ICustomerBusiness
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerBusiness(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public MessageBagSingleEntityVO<Customer> GetCustomer(uint id)
    {
        Customer customer = _customerRepository.GetCustomer(id);
        return customer == null ?
            new MessageBagSingleEntityVO<Customer>("Cliente não encontrado", "Erro ao buscar cliente") :
            new MessageBagSingleEntityVO<Customer>("Cliente encontrado com sucesso", "Sucesso", false, customer);
    }

    public MessageBagSingleEntityVO<Customer> GetCustomerByEmail(string email)
    {
        Customer customer = _customerRepository.GetCustomerByEmail(email);
        return customer == null ?
            new MessageBagSingleEntityVO<Customer>("Cliente não encontrado", "Erro ao buscar cliente") : 
            new MessageBagSingleEntityVO<Customer>("Cliente encontrado com sucesso", "Sucesso", false, customer);
    }
}
