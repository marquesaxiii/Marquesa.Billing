using System;
using System.Collections.Generic;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class Client
    {
        public Client()
        {
            Appointments = new HashSet<Appointment>();
        }

        public long Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public int Contact { get; set; }
        public string Image { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Guid { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
