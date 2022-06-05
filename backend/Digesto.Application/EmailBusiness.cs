using Digesto.Application.Interfaces;
using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Domain.Entities;
using Digesto.Infra.Interfaces;

namespace Digesto.Application;

public class EmailBusiness : IEmailBusiness
{
    private readonly IEmailRepository _emailRepository;

    public EmailBusiness(IEmailRepository emailRepository)
    {
        _emailRepository = emailRepository;
    }

    public MessageBagSingleEntityVO<Email> GetEmail(Broker broker, uint id)
    {
        Email email = _emailRepository.GetEmail(id);
        if (email == null)
            return new MessageBagSingleEntityVO<Email>("Este email não existe", "Erro ao buscar email");

        return email.InsuranceQuoteRequest.BrokerId == broker.Id ?
            new MessageBagSingleEntityVO<Email>("Email encontrado", "Sucesso", false, email) :
            new MessageBagSingleEntityVO<Email>("Este email não é seu", "Erro");
    }

    public MessageBagListEntityVO<Email> GetEmailsPerBroker(PaginationDTO pagination, Broker broker)
    {
        int total = _emailRepository.GetTotalEmailsByBroker(broker.Id);
        pagination.FillBasedInTotalItems((uint)total);

        List<Email> emails = 
            _emailRepository.GetEmailsByBroker(pagination, broker.Id);

        MessageBagListEntityVO<Email> messageBagEmail = new("Emails encontrados", "Sucesso", false);
        messageBagEmail.Pagination = pagination;
        messageBagEmail.Entities = emails;
        return messageBagEmail;
    }

    public MessageBagListEntityVO<Email> GetEmailsPerInsuranceQuoteRequest(PaginationDTO pagination, Broker broker, uint insuranceQuoteRequestId)
    {
        InsuranceQuoteRequest insuranceQuoteRequest = 
            broker.InsuranceQuoteRequests.FirstOrDefault(x => x.BrokerId == broker.Id && x.Id == insuranceQuoteRequestId);
        if (insuranceQuoteRequest == null)
            return new MessageBagListEntityVO<Email>("Os emails referentes a esse pedido de cotação não pertencem a você", "Sem permissão");

        List<Email> emails = insuranceQuoteRequest.Emails;
        uint total = (uint)emails.Count;

        MessageBagListEntityVO<Email> messageBagEmail = new("Emails encontrados com sucesso", "Sucesso", false);
        messageBagEmail.Entities = emails;
        messageBagEmail.Pagination.FillBasedInTotalItems(total);
        return messageBagEmail;
    }
}
