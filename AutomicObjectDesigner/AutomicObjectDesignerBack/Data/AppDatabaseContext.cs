using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesigner.Models.Registration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace AutomicObjectDesignerBack.Data
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<FileTransfer> FileTransfers { get; set; }
        DbSet<LinuxSimple> LinuxSimple { get; set; }
        DbSet<SapSimple> SapSimple { get; set; }

        DbSet<SapVariantCopy> SapVariantCopy { get; set; }
        DbSet<WindowsSimple> WindowsSimple { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");
            modelBuilder.Entity<User>()
                .Property(s => s.Id)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.FirstName)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.LastName)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.UserName)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.Email)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.Password)
                .IsRequired(true);
            modelBuilder.Entity<User>()
                .Property(s => s.HasEmailConfirmed)
                .IsRequired()
                .HasDefaultValue(false);
            modelBuilder.Entity<User>()
                .Property(s => s.IsAdministrator)
                .IsRequired()
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        UserName = "12345",
                        Email = "Johndoe@gmail.com",
                        Password = "admin",
                        HasEmailConfirmed = true,
                        IsAdministrator = true

                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Eva",
                        LastName = "Doe",
                        UserName = "34567",
                        Email = "evathe2@gmail.com",
                        Password = "haslo",
                        HasEmailConfirmed = true,
                        IsAdministrator = false

                    }
                );
        }
    }
}
