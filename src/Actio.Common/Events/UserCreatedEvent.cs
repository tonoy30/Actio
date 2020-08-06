namespace Actio.Common.Events
{
    public class UserCreatedEvent : IEvent
    {
        public string Email { get; }
        public string UserName { get; }

        protected UserCreatedEvent()
        {
        }

        public UserCreatedEvent(string userName, string email)
        {
            Email = email;
            UserName = userName;
        }
    }
}