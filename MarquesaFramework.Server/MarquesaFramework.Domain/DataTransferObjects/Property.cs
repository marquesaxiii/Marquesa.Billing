using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Property
    {
        public Property()
        {
            Comments = new HashSet<Comment>();
            Owners = new HashSet<Owner>();
        }

        public long Id { get; set; }
        public string PropertyName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long AgentId { get; set; }
        public long PropertyTypeId { get; set; }
        public int Price { get; set; }
        public string Status { get; set; } = null!;
        public long AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;

        public virtual Admin Admin { get; set; } = null!;
        public virtual Agent Agent { get; set; } = null!;
        public virtual PropertyType PropertyType { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
