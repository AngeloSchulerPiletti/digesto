namespace Digesto.Application.Models.DTO;

public class PaginationDTO
{
    public PaginationDTO(uint page = 1, uint limit = 10)
    {
        Page = page;
        Limit = limit;
        Skip = limit * (page - 1);
    }

    public uint Page { get; set; }
    public uint Limit { get; set; }
    public uint Skip { get; set; }
    public uint? LastPage { get; set; }
    public uint? NextPage { get; set; }
    public uint? PreviousPage { get; set; }
    public uint? TotalItems { get; set; }

    public void FillBasedInTotalItems(uint totalItems)
    {
        TotalItems = totalItems;
        LastPage = (uint?)Math.Ceiling(Decimal.Divide(totalItems, Limit));
        NextPage = (Page * Limit < totalItems) ? (Page + 1 <= LastPage ? Page + 1 : null) : null;
        PreviousPage = Page > 1 ? (Page - 1 < LastPage ? Page - 1 : null) : null;
    }
}
