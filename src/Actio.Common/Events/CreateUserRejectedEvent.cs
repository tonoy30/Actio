namespace Actio.Common.Events
{
    public class CreateUserRejectedEvent : IRejectedEvent
    {
        public string Email { get; set; }
        public string Message { get; }
        public string Code { get; }

        protected CreateUserRejectedEvent()
        {
        }

        public CreateUserRejectedEvent(string email, string message, string code)
        {
            Email = email;
            Message = message;
            Code = code;
        }
    }
}