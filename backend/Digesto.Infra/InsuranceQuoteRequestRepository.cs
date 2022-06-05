using Digesto.Application.Models.DTO;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;
using System.Linq;

namespace Digesto.Infra;

public class InsuranceQuoteRequestRepository : IInsuranceQuoteRequestRepository
{
    private readonly DigestoContext _context;
    public InsuranceQuoteRequestRepository(DigestoContext context)
    {
        _context = context;
    }

    public InsuranceQuoteRequest GetInsuranceQuoteRequest(uint id)
    {
        return _context.InsuranceQuoteRequests.Find(id);
    }

    public List<InsuranceQuoteRequest> GetInsuranceQuoteRequestsByBroker(PaginationDTO pagination, uint brokerId)
    {
        return _context.InsuranceQuoteRequests
                            .Where(x => x.BrokerId == brokerId)
                            .Skip((int)pagination.Skip)
                            .Take((int)pagination.Limit)
                            .ToList();
    }
    public List<InsuranceQuoteRequest> GetInsuranceQuoteRequestsByCustomer(PaginationDTO pagination, uint customerId)
    {
        return _context.InsuranceQuoteRequests
                    .Where(x => x.CustomerId == customerId)
                    .Skip((int)pagination.Skip)
                    .Take((int)pagination.Limit)
                    .ToList();
    }

    public int GetTotalInsuranceQuoteRequestsByBroker(uint brokerId)
    {
        return _context.InsuranceQuoteRequests
                    .Where(x => x.BrokerId == brokerId)
                    .Select(x => x.Id)
                    .Count();
    }

    public int GetTotalInsuranceQuoteRequestsByCustomer(uint customerId)
    {
        return _context.InsuranceQuoteRequests
                    .Where(x => x.CustomerId == customerId)
                    .Select(x => x.Id)
                    .Count();
    }
}
