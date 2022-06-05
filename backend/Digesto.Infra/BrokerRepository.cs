using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Infra;

internal class BrokerRepository : IBrokerRepository
{
    private readonly DigestoContext _context;

    public BrokerRepository(DigestoContext context)
    {
        _context = context;
    }

    public Broker GetBroker(uint id)
    {
        return _context.Brokers.Find(id);
    }

    public Broker GetBrokerByEmail(string email)
    {
        return _context.Brokers.FirstOrDefault(x => x.Email == email);
    }
}
