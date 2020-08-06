using System;

namespace Actio.Common.Events
{
    public class ActivityCreatedEvent : IAuthenticatedEvent
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        protected ActivityCreatedEvent()
        {
        }

        public ActivityCreatedEvent(string userId, string id, string category,
            string name, string description, DateTime createdAt)
        {
            UserId = userId;
            Id = id;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}