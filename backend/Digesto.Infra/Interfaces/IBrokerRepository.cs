using Digesto.Domain.Entities;

namespace Digesto.Infra.Interfaces;

public interface IBrokerRepository
{
    public Broker GetBroker(uint id);
    public Broker GetBrokerByEmail(string email);
}
