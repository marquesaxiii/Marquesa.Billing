using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Admin
    {
        public Admin()
        {
            Appointments = new HashSet<Appointment>();
            Comments = new HashSet<Comment>();
            Notifications = new HashSet<Notification>();
            Properties = new HashSet<Property>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public int Contact { get; set; }
        public string Email { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
