using System;
using System.Threading.Tasks;
using Actio.Common.Command;
using Actio.Common.Events;
using RawRabbit;

namespace Actio.Services.Identity
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IBusClient _busClient;

        public CreateUserCommandHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateUserCommand command)
        {
            Console.WriteLine(
                $"Creating {nameof(UserCreatedEvent)} Activity: {nameof(CreateUserCommandHandler)} ==> {command.UserName}");
            await _busClient.PublishAsync(new UserCreatedEvent(command.UserName, command.Email));
        }
    }
}