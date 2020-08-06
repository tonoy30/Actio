using System;
using System.Threading.Tasks;
using Actio.Common.Command;
using Actio.Common.Events;
using RawRabbit;

namespace Actio.Services.Activities.Handlers
{
    public class CreateActivityCommandHandler : ICommandHandler<CreateActivityCommand>
    {
        private readonly IBusClient _busClient;

        public CreateActivityCommandHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateActivityCommand command)
        {
            Console.WriteLine($"Creating Activity: {nameof(CreateActivityCommandHandler)} ==> {command.Name}");
            await _busClient.PublishAsync(new ActivityCreatedEvent(command.UserId, command.Id, command.Category,
                command.Name, command.Description, command.CreatedAt));
        }
    }
}