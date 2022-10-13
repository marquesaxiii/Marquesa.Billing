using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Identity.Domain.DataTransferObjects
{
    public partial class MarquesaSystemContext : DbContext
    {
        public MarquesaSystemContext()
        {
        }

        public MarquesaSystemContext(DbContextOptions<MarquesaSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Credential> Credentials { get; set; } = null!;
        public virtual DbSet<IdentityInformation> IdentityInformations { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleEntity> RoleEntities { get; set; } = null!;
        public virtual DbSet<Verification> Verifications { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=MarquesaSystem;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Identity");

                entity.HasIndex(e => e.Guid, "Address_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Address_Id_key")
                    .IsUnique();

                entity.Property(e => e.Barangay).HasColumnType("character varying");

                entity.Property(e => e.Building).HasColumnType("character varying");

                entity.Property(e => e.City).HasColumnType("character varying");

                entity.Property(e => e.Country).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Province).HasColumnType("character varying");

                entity.Property(e => e.Region).HasColumnType("character varying");

                entity.Property(e => e.Street).HasColumnType("character varying");

                entity.Property(e => e.UnitNumber).HasColumnType("character varying");

                entity.Property(e => e.ZipCode).HasColumnType("character varying");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact", "Identity");

                entity.HasIndex(e => e.EmailAddress, "Contact_EmailAddress_key")
                    .IsUnique();

                entity.HasIndex(e => e.Guid, "Contact_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Contact_Id_key")
                    .IsUnique();

                entity.Property(e => e.EmailAddress).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Credential>(entity =>
            {
                entity.ToTable("Credential", "Identity");

                entity.HasIndex(e => e.Guid, "Credential_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Credential_Id_key")
                    .IsUnique();

                entity.HasIndex(e => e.Password, "Credential_Password_key")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "Credential_UserName_key")
                    .IsUnique();

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.IdentityInformation)
                    .WithMany(p => p.Credentials)
                    .HasForeignKey(d => d.IdentityInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credential_identityinformation_id_fk");
            });

            modelBuilder.Entity<IdentityInformation>(entity =>
            {
                entity.ToTable("IdentityInformation", "Identity");

                entity.HasIndex(e => e.Guid, "IdentityInformation_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "IdentityInformation_Id_key")
                    .IsUnique();

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.IdentityInformations)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("identityinformation_address_id_fk");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.IdentityInformations)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("identityinformation_contact_id_fk");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "Identity");

                entity.HasIndex(e => e.Guid, "Role_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Role_Id_key")
                    .IsUnique();

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("true");

                entity.HasOne(d => d.Credential)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.CredentialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role_credential_id_fk");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role_roleentity_id_fk");
            });

            modelBuilder.Entity<RoleEntity>(entity =>
            {
                entity.ToTable("RoleEntity", "Identity");

                entity.HasIndex(e => e.Guid, "RoleEntity_Guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "RoleEntity_Id_key")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Verification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Verification", "Identity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
