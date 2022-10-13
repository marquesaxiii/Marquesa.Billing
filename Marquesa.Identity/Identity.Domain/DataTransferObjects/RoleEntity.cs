using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class RoleEntity
    {
        public RoleEntity()
        {
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public short RoleLevel { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
