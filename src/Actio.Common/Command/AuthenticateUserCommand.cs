namespace Actio.Common.Command
{
    public class AuthenticateUserCommand : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}