using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class IdentityInformation
    {
        public IdentityInformation()
        {
            Credentials = new HashSet<Credential>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public short Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public short CivilStatus { get; set; }
        public long AddressId { get; set; }
        public long ContactId { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Contact Contact { get; set; } = null!;
        public virtual ICollection<Credential> Credentials { get; set; }
    }
}
