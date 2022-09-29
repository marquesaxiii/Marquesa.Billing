using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Owner
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public long PropertyId { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long AgentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;

        public virtual Agent Agent { get; set; } = null!;
        public virtual Property Property { get; set; } = null!;
    }
}
