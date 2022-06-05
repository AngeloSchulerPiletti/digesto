using Digesto.Application.Interfaces;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Application;

public class BrokerBusiness : IBrokerBusiness
{
    private readonly IBrokerRepository _brokerRepository;

    public BrokerBusiness(IBrokerRepository brokerRepository)
    {
        _brokerRepository = brokerRepository;
    }

    public MessageBagSingleEntityVO<Broker> GetBroker(uint id)
    {
        Broker broker = _brokerRepository.GetBroker(id);
        return broker == null ?
            new MessageBagSingleEntityVO<Broker>("Corretor não encontrado", "Erro ao buscar corretor") :
            new MessageBagSingleEntityVO<Broker>("Corretor encontrado com sucesso", "Sucesso", false, broker);
    }

    public MessageBagSingleEntityVO<Broker> GetBrokerByEmail(string email)
    {
        Broker broker = _brokerRepository.GetBrokerByEmail(email);
        return broker == null ?
            new MessageBagSingleEntityVO<Broker>("Corretor não encontrado", "Erro ao buscar corretor") :
            new MessageBagSingleEntityVO<Broker>("Corretor encontrado com sucesso", "Sucesso", false, broker);
    }
}
