using System;

namespace Actio.Common.Command
{
    public interface IAuthenticatedCommand : ICommand
    {
        string UserId { get; set; }
    }
}