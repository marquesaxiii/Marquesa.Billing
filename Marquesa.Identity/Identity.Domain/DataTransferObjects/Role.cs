using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class Role
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public long EntityId { get; set; }
        public long CredentialId { get; set; }

        public virtual Credential Credential { get; set; } = null!;
        public virtual RoleEntity Entity { get; set; } = null!;
    }
}
