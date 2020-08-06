namespace Actio.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        string UserId { get; set; }
    }
}