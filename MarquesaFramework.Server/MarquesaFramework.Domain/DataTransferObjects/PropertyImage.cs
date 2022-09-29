using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class PropertyImage
    {
        public PropertyImage()
        {
            PropertyTypes = new HashSet<PropertyType>();
        }

        public long Id { get; set; }
        public string ImageName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public string Guid { get; set; } = null!;

        public virtual ICollection<PropertyType> PropertyTypes { get; set; }
    }
}
