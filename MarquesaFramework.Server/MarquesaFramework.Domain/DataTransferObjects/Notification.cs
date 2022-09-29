using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Notification
    {
        public long Id { get; set; }
        public string NotificationName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Guid { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Admin Admin { get; set; } = null!;
    }
}
