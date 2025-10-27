namespace Notifications.Domain
{
    public abstract class AbstractMessage
    {
        protected IMessageSender _messageSender = null!;
        public abstract string SendMessage(string Message);        
    }
}
