using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;

namespace Digesto.Application.Interfaces;

public interface IEmailBusiness
{
    public MessageBagSingleEntityVO<Email> GetEmail(Broker broker, uint emailId);
    public MessageBagListEntityVO<Email> GetEmailsPerBroker(PaginationDTO pagination, Broker broker);
    public MessageBagListEntityVO<Email> GetEmailsPerInsuranceQuoteRequest(PaginationDTO pagination, Broker broker, uint insuranceQuoteRequestId);
}
