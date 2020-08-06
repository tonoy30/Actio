﻿using System;

namespace Actio.Common.Command
{
    public class CreateActivityCommand : IAuthenticatedCommand
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}