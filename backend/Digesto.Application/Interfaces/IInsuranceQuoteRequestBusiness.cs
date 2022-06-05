using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;

namespace Digesto.Application.Interfaces;

public interface IInsuranceQuoteRequestBusiness
{
    public MessageBagSingleEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequest(Broker broker, uint id);
    public MessageBagListEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequestPerBroker(PaginationDTO pagination, Broker broker);
}
