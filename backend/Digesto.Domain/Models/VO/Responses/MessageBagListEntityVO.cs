using Digesto.Application.Models.DTO;

namespace Digesto.Application.Models.VO.Responses
{
    public class MessageBagListEntityVO<TEntity> : MessageBagVO where TEntity : class
    {
        public MessageBagListEntityVO(string message = null,
                            string title = null,
                            bool isError = true,
                            TEntity entity = null,
                            string errorCode = null
                            ) : base(message, title, isError, errorCode)
        {
            Entities = entity != null ? new List<TEntity>() { entity } : new List<TEntity>();
        }

        public List<TEntity> Entities { get; set; }
        public PaginationDTO Pagination { get; set; } 
    }
}
