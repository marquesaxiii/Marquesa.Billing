using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class PropertyType
    {
        public PropertyType()
        {
            Properties = new HashSet<Property>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long PropertyImageId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Guid { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }

        public virtual PropertyImage PropertyImage { get; set; } = null!;
        public virtual ICollection<Property> Properties { get; set; }
    }
}
