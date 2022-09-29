using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MarquesaFramework.Domain.DataTransferObjects
{
    public partial class MarquesaSystemsContext : DbContext
    {
        public MarquesaSystemsContext()
        {
        }

        public MarquesaSystemsContext(DbContextOptions<MarquesaSystemsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<PropertyImage> PropertyImages { get; set; } = null!;
        public virtual DbSet<PropertyType> PropertyTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=MarquesaSystems;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin", "Admin");

                entity.HasIndex(e => e.Guid, "admin_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "admin_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.Image).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.MiddleName).HasColumnType("character varying");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("Agent", "Agent");

                entity.HasIndex(e => e.Guid, "agent_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "agent_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.Image).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.MiddleName).HasColumnType("character varying");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment", "Appointment");

                entity.HasIndex(e => e.Guid, "appointment_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "appointment_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointment_admin_id_fk");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointment_agent_id_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointment_client_id_fk");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client", "Client");

                entity.HasIndex(e => e.Guid, "client_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "client_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.Image).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.MiddleName).HasColumnType("character varying");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment", "Appointment");

                entity.HasIndex(e => e.Guid, "comment_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "comment_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment1)
                    .HasColumnType("character varying")
                    .HasColumnName("Comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comment_admin_id_fk");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comment_agent_id_fk");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comment_property_id_fk");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification", "Appointment");

                entity.HasIndex(e => e.Guid, "notification_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "notification_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.NotificationName).HasColumnType("character varying");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notification_admin_id_fk");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner", "Owner");

                entity.HasIndex(e => e.Guid, "owner_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "owner_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.MiddleName).HasColumnType("character varying");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Owners)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("owner_agent_id_fk");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Owners)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("owner_property_id_fk");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property", "Property");

                entity.HasIndex(e => e.Guid, "property_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "property_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.PropertyName).HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("property_admin_id_fk");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("property_agent_id_fk");

                entity.HasOne(d => d.PropertyType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropertyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("property_propertytype_id_fk");
            });

            modelBuilder.Entity<PropertyImage>(entity =>
            {
                entity.ToTable("PropertyImage", "Property");

                entity.HasIndex(e => e.Guid, "propertyimage_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "propertyimage_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.ImageName).HasColumnType("character varying");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("false");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<PropertyType>(entity =>
            {
                entity.ToTable("PropertyType", "Property");

                entity.HasIndex(e => e.Guid, "propertytype_guid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "propertytype_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasColumnType("character varying");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TypeName).HasColumnType("character varying");

                entity.HasOne(d => d.PropertyImage)
                    .WithMany(p => p.PropertyTypes)
                    .HasForeignKey(d => d.PropertyImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("propertytype_propertyimage_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
