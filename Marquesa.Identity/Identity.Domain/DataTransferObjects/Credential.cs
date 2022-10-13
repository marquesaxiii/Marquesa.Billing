using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class Credential
    {
        public Credential()
        {
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public short Status { get; set; }
        public long IdentityInformationId { get; set; }

        public virtual IdentityInformation IdentityInformation { get; set; } = null!;
        public virtual ICollection<Role> Roles { get; set; }
    }
}
