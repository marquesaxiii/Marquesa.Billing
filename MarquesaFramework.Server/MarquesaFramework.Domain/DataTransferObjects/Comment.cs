using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Comment
    {
        public long Id { get; set; }
        public string Comment1 { get; set; } = null!;
        public long PropertyId { get; set; }
        public long AgentId { get; set; }
        public long AdminId { get; set; }
        public string Status { get; set; } = null!;
        public DateOnly Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Guid { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual Admin Admin { get; set; } = null!;
        public virtual Agent Agent { get; set; } = null!;
        public virtual Property Property { get; set; } = null!;
    }
}
