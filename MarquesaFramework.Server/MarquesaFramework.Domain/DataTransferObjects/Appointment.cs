using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Appointment
    {
        public long Id { get; set; }
        public string Description { get; set; } = null!;
        public string? Status { get; set; }
        public long AgentId { get; set; }
        public long ClientId { get; set; }
        public long AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Guid { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Admin Admin { get; set; } = null!;
        public virtual Agent Agent { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
