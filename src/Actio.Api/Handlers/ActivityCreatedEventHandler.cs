using System;
using System.Threading.Tasks;
using Actio.Common.Events;

namespace Actio.Api
{
    public class ActivityCreatedEventHandler : IEventHandler<ActivityCreatedEvent>
    {
        public async Task HandleAsync(ActivityCreatedEvent @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"{nameof(ActivityCreatedEvent)} ==> {@event.Name}");
        }
    }
}