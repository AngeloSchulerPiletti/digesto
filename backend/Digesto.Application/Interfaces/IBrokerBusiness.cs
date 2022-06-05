using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;

namespace Digesto.Application.Interfaces;

public interface IBrokerBusiness
{
    public MessageBagSingleEntityVO<Broker> GetBroker(uint id);
    public MessageBagSingleEntityVO<Broker> GetBrokerByEmail(string email);
}
