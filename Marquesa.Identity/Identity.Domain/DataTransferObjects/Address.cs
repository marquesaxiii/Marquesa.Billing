using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class Address
    {
        public Address()
        {
            IdentityInformations = new HashSet<IdentityInformation>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public string UnitNumber { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string? Building { get; set; }
        public string? Barangay { get; set; }
        public string City { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string ZipCode { get; set; } = null!;

        public virtual ICollection<IdentityInformation> IdentityInformations { get; set; }
    }
}
