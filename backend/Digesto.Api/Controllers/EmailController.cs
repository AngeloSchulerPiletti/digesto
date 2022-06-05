using Digesto.Api.ControllerAttributes;
using Digesto.Application.Interfaces;
using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Digesto.Api.Controllers;

[Route("api/email")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly ICustomerBusiness _customerBusiness;
    private readonly IBrokerBusiness _brokerBusiness;
    private readonly IEmailBusiness _emailBusiness;

    public EmailController(ICustomerBusiness customerBusiness,
                                           IBrokerBusiness brokerBusiness,
                                           IEmailBusiness emailBusiness)
    {
        _customerBusiness = customerBusiness;
        _brokerBusiness = brokerBusiness;
        _emailBusiness = emailBusiness;
    }

    [HttpGet]
    [Route("broker/{id}")]
    [Pagination]
    IActionResult GetEmailsByBroker(uint id) //Futuramente usando o token para obter o id do broker
    {
        PaginationDTO pagination = (PaginationDTO)HttpContext.Items["Pagination"];

        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(id);
        if (messageBagBroker.IsError) return BadRequest(messageBagBroker);

        MessageBagListEntityVO<Email> messageBagEmails =
            _emailBusiness.GetEmailsPerBroker(pagination, messageBagBroker.Entity);
        return messageBagEmails.IsError ?
            BadRequest(messageBagEmails) :
            Ok(messageBagEmails);
    }

    [HttpGet]
    [Route("insurance-quote-request/{brokerId}/{id}")]
    [Pagination]
    IActionResult GetEmailsByInsuranceQuoteRequest(uint id, uint brokerId) //Futuramente usando o token para obter o id do broker
    {
        PaginationDTO pagination = (PaginationDTO)HttpContext.Items["Pagination"];

        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(brokerId);
        if (messageBagBroker.IsError) return BadRequest(messageBagBroker);

        MessageBagListEntityVO<Email> messageBagEmails =
            _emailBusiness.GetEmailsPerInsuranceQuoteRequest(pagination, messageBagBroker.Entity, id);
        return messageBagEmails.IsError ?
            BadRequest(messageBagEmails) :
            Ok(messageBagEmails);
    }

    [HttpGet]
    [Route("{brokerId}/{emailId}")]
    IActionResult GetEmail(uint brokerId, uint emailId) //Futuramente usando o token para obter o id do broker
    {
        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(brokerId);
        if (messageBagBroker.IsError) return BadRequest(messageBagBroker);

        MessageBagSingleEntityVO<Email> messageBagEmail =
            _emailBusiness.GetEmail(messageBagBroker.Entity, emailId);
        return messageBagEmail.IsError ?
            BadRequest(messageBagEmail) : Ok(messageBagEmail);
    }
}
