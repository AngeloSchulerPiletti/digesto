using Digesto.Application.Interfaces;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digesto.Api.Controllers;

[Route("api/broker")]
[ApiController]
public class BrokerController : ControllerBase
{
    private readonly IBrokerBusiness _brokerBusiness;

    public BrokerController(IBrokerBusiness brokerBusiness)
    {
        _brokerBusiness = brokerBusiness;
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetBroker(uint id)
    {
        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBroker(id);
        return messageBagBroker.IsError ? BadRequest(messageBagBroker) : Ok(messageBagBroker);
    }

    [HttpGet]
    public IActionResult GetBroker([FromBody] string email)
    {
        MessageBagSingleEntityVO<Broker> messageBagBroker = _brokerBusiness.GetBrokerByEmail(email);
        return messageBagBroker.IsError ? BadRequest(messageBagBroker) : Ok(messageBagBroker);
    }
}
