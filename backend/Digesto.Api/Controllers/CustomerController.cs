using Digesto.Application.Interfaces;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digesto.Api.Controllers;

[Route("api/customer")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerBusiness _customerBusiness;

    public CustomerController(ICustomerBusiness customerBusiness)
    {
        _customerBusiness = customerBusiness;
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetCustomer(uint id)
    {
        MessageBagSingleEntityVO<Customer> messageBagCustomer = _customerBusiness.GetCustomer(id);
        return messageBagCustomer.IsError ? BadRequest(messageBagCustomer) : Ok(messageBagCustomer);
    }
}
