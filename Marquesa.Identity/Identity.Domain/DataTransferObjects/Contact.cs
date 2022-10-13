using System;
using System.Collections.Generic;

namespace Identity.Domain.DataTransferObjects
{
    public partial class Contact
    {
        public Contact()
        {
            IdentityInformations = new HashSet<IdentityInformation>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;
        public int MobileNumber { get; set; }
        public string EmailAddress { get; set; } = null!;

        public virtual ICollection<IdentityInformation> IdentityInformations { get; set; }
    }
}
