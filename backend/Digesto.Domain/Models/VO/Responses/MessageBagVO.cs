namespace Digesto.Application.Models.VO.Responses
{
    public class MessageBagVO : IMessageBaseVO
    {
        public MessageBagVO(string message = null,
                            string title = null,
                            bool isError = true,
                            string errorCode = null)
        {
            Title = title;
            IsError = isError;
            ErrorCode = errorCode;
            Messages = message == null ? new List<string>() : new List<string>() { message };
        }

        public string Title { get; set; }
        public bool IsError { get; set; }
        public List<string> Messages { get; }
        public string ErrorCode { get; set; }
    }
}
