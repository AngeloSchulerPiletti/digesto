namespace Digesto.Application.Models.VO.Responses
{
    public interface IMessageBaseVO
    {
        public string Title { get; set; }
        public bool IsError { get; }
        public string ErrorCode { get; }
    }
}