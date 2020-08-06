namespace Actio.Common.Events
{
    public class UserAuthenticatedEvent : IEvent
    {
        public string Email { get; }

        protected UserAuthenticatedEvent()
        {
        }

        public UserAuthenticatedEvent(string email)
        {
            Email = email;
        }
    }
}