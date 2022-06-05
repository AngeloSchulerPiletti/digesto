using Digesto.Api.ControllerAttributes;
using Digesto.Application.Interfaces;
using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digesto.Api.Controllers;

[Route("api/insurance-quote-request")]
[ApiController]
public class InsuranceQuoteRequestController : ControllerBase
{
    private readonly ICustomerBusiness _customerBusiness;
    private readonly IBrokerBusiness _brokerBusiness;
    private readonly IInsuranceQuoteRequestBusiness _insuranceQuoteRequestBusiness;

    public InsuranceQuoteRequestController(ICustomerBusiness customerBusiness, 
                                           IBrokerBusiness brokerBusiness, 
                                           IInsuranceQuoteRequestBusiness insuranceQuoteRequestBusiness)
    {
        _customerBusiness = customerBusiness;
        _brokerBusiness = brokerBusiness;
        _insuranceQuoteRequestBusiness = insuranceQuoteRequestBusiness;
    }

    [HttpGet]
    [Route("broker/{id}")]
    [Pagination]
    IActionResult GetInsuranceQuoteRequestsByBroker(uint id) //Futuramente usando o token para obter o id do broker
    {
        PaginationDTO pagination = (PaginationDTO)HttpContext.Items["Pagination"];

        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(id);
        if (messageBagBroker.IsError) return BadRequest(messageBagBroker);

        MessageBagListEntityVO<InsuranceQuoteRequest> messageBagInsuranceQuoteRequests =
            _insuranceQuoteRequestBusiness.GetInsuranceQuoteRequestPerBroker(pagination, messageBagBroker.Entity);
        return messageBagInsuranceQuoteRequests.IsError ? 
            BadRequest(messageBagInsuranceQuoteRequests) : 
            Ok(messageBagInsuranceQuoteRequests);
    }

    [HttpGet]
    [Route("{brokerId}/{insuranceQuoteRequestId}")]
    IActionResult GetInsuranceQuoteRequest(uint brokerId, uint insuranceQuoteRequestId) //Futuramente usando o token para obter o id do broker
    {
        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(brokerId);
        if (messageBagBroker.IsError) return BadRequest(messageBagBroker);

        MessageBagSingleEntityVO<InsuranceQuoteRequest> messageBagInsuranceQuoteRequest = 
            _insuranceQuoteRequestBusiness.GetInsuranceQuoteRequest(messageBagBroker.Entity, insuranceQuoteRequestId);
        return messageBagInsuranceQuoteRequest.IsError ?
            BadRequest(messageBagInsuranceQuoteRequest) : Ok(messageBagInsuranceQuoteRequest);
    }
}
