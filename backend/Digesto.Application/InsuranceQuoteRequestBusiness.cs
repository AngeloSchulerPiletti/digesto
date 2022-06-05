using Digesto.Application.Interfaces;
using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Application;

public class InsuranceQuoteRequestBusiness : IInsuranceQuoteRequestBusiness
{
    private readonly IInsuranceQuoteRequestRepository _insuranceQuoteRequestRepository;

    public InsuranceQuoteRequestBusiness(IInsuranceQuoteRequestRepository insuranceQuoteRequestRepository)
    {
        _insuranceQuoteRequestRepository = insuranceQuoteRequestRepository;
    }

    public MessageBagSingleEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequest(Broker broker, uint id)
    {
        InsuranceQuoteRequest insuranceQuoteRequest = broker.InsuranceQuoteRequests.FirstOrDefault(x => x.Id == id);
        return insuranceQuoteRequest == null ?
            new MessageBagSingleEntityVO<InsuranceQuoteRequest>("Este pedido de orçamento não é seu ou não existe", "Erro") :
            new MessageBagSingleEntityVO<InsuranceQuoteRequest>("Pedido de orçamento encontrado", "Sucesso", false, insuranceQuoteRequest);
    }

    public MessageBagListEntityVO<InsuranceQuoteRequest> GetInsuranceQuoteRequestsPerBroker(PaginationDTO pagination, Broker broker)
    {
        int total = _insuranceQuoteRequestRepository.GetTotalInsuranceQuoteRequestsByBroker(broker.Id);
        pagination.FillBasedInTotalItems((uint)total);

        List<InsuranceQuoteRequest> insuranceQuoteRequests = 
            _insuranceQuoteRequestRepository.GetInsuranceQuoteRequestsByBroker(pagination, broker.Id);

        MessageBagListEntityVO<InsuranceQuoteRequest> messageBagInsuranceQuoteRequest = new("Pedidos de seguros encontrados", "Sucesso", false);
        messageBagInsuranceQuoteRequest.Pagination = pagination;
        messageBagInsuranceQuoteRequest.Entities = insuranceQuoteRequests;
        return messageBagInsuranceQuoteRequest;
    }
}
