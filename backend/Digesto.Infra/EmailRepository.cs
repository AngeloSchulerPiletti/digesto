using Digesto.Application.Models.DTO;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;
using System.Linq;

namespace Digesto.Infra;

public class EmailRepository : IEmailRepository
{
    private readonly DigestoContext _context;
    public EmailRepository(DigestoContext context)
    {
        _context = context;
    }

    public Email GetEmail(uint id)
    {
        return _context.Emails.Find(id);
    }

    public List<Email> GetEmailsByBroker(PaginationDTO pagination, uint brokerId)
    {
        return _context.Emails
                            .Where(x => x.InsuranceQuoteRequest.BrokerId == brokerId)
                            .Skip((int)pagination.Skip)
                            .Take((int)pagination.Limit)
                            .ToList();
    }
    public List<Email> GetEmailsByCustomer(PaginationDTO pagination, uint customerId)
    {
        return _context.Emails
                    .Where(x => x.InsuranceQuoteRequest.CustomerId == customerId)
                    .Skip((int)pagination.Skip)
                    .Take((int)pagination.Limit)
                    .ToList();
    }

    public List<Email> GetEmailsByInsuranceQuoteRequest(PaginationDTO pagination, uint insuranceQuoteRequestId)
    {
        return _context.Emails
                    .Where(x => x.InsuranceQuoteRequestId == insuranceQuoteRequestId)
                    .Skip((int)pagination.Skip)
                    .Take((int)pagination.Limit)
                    .ToList();
    }

    public int GetTotalEmailsByBroker(uint brokerId)
    {
        return _context.Emails
                    .Where(x => x.InsuranceQuoteRequest.BrokerId == brokerId)
                    .Select(x => x.Id)
                    .Count();
    }

    public int GetTotalEmailsByCustomer(uint customerId)
    {
        return _context.Emails
                    .Where(x => x.InsuranceQuoteRequest.CustomerId == customerId)
                    .Select(x => x.Id)
                    .Count();
    }

    public int GetTotalEmailsByInsuranceQuoteRequest(uint insuranceQuoteRequestId)
    {
        return _context.Emails
                    .Where(x => x.InsuranceQuoteRequestId == insuranceQuoteRequestId)
                    .Select(x => x.Id)
                    .Count();
    }
}
