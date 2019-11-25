using System;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Entities
{
    public class Entity
    {
        public Guid Id { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; }
        public DateTimeOffset? UpdatedAt { get; private set; }
        public IList<string> Notifications { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.UtcNow;
        }

        public void SetUpdateDate(DateTimeOffset updatedAt) => UpdatedAt = updatedAt;

        public void AddNotification(string notification) => Notifications.Add(notification);
    }
}
