using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;

namespace Digesto.Application.Interfaces;

public interface IInsuranceQuoteRequestBusiness
{
    public MessageBagSingleEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequest(Broker broker, uint insuranceQuoteRequestId);
    public MessageBagListEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequestsPerBroker(PaginationDTO pagination, Broker broker);
}
