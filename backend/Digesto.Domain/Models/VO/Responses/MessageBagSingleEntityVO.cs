namespace Digesto.Application.Models.VO.Responses
{
    public class MessageBagSingleEntityVO<TEntity> : MessageBagVO where TEntity : class
    {
        public MessageBagSingleEntityVO(string message = null,
                            string title = null,
                            bool isError = true,
                            TEntity entity = null,
                            string errorCode = null
                            ) : base(message, title, isError, errorCode)
        {
            Entity = entity;
        }

        public TEntity Entity { get; set; }

        public MessageBagSingleEntityVO<TEntity> MapFromMessageBagVO(MessageBagVO messageBagVO, TEntity entity = null)
        {
            this.Messages.AddRange(messageBagVO.Messages);
            this.Title = messageBagVO.Title;
            this.IsError = messageBagVO.IsError;
            this.Entity = entity;
            this.ErrorCode = messageBagVO.ErrorCode;

            return this;
        }

        public static MessageBagSingleEntityVO<TEntity> NewMessageBagSingleEntityVOFromDifferentType<FromEntity>(MessageBagSingleEntityVO<FromEntity> messageBag) where FromEntity : class
        {
            MessageBagSingleEntityVO<TEntity> newBag = new();
            newBag.Title = messageBag.Title;
            newBag.Messages.AddRange(messageBag.Messages);
            newBag.ErrorCode = messageBag.ErrorCode;
            newBag.IsError = messageBag.IsError;

            return newBag;
        }
    }
}
