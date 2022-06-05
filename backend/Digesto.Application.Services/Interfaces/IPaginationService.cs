using Digesto.Application.Models.DTO;
using Digesto.Application.Models.VO.Responses;

namespace Digesto.Application.Services.Interfaces;

public interface IPaginationService
{
    public MessageBagSingleEntityVO<PaginationDTO> MapPagination(uint page, uint limit);
}
