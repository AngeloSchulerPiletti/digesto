using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;
using Digesto.Application.Services.Interfaces;

namespace Digesto.Application.Services;

public class PaginationService : IPaginationService
{
    public MessageBagSingleEntityVO<PaginationDTO> MapPagination(uint page, uint limit)
    {
        return  (page == 0 || limit == 0) ?
            new MessageBagSingleEntityVO<PaginationDTO>("A paginação não pode ter página 0 ou limite 0", "Erro ao mapear a paginação", true, null, "P001") :
            new MessageBagSingleEntityVO<PaginationDTO>("Mapeado com sucesso", null, false, new PaginationDTO(page, limit));
    }
}
