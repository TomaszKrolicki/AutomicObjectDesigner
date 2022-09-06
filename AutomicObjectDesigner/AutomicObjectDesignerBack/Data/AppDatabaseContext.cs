using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesigner.Models.Registration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using AutomicObjectDesignerBack.Models.Objects;

namespace AutomicObjectDesignerBack.Data
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FileTransfer> FileTransfers { get; set; }
        public DbSet<LinuxSimple> LinuxSimple { get; set; }
        public DbSet<SapSimple> SapSimple { get; set; }
        public DbSet<UnixGeneral> UnixGeneral { get; set; }
        public DbSet<SapJobBwChain> SapJobBwChains { get; set; }

        public DbSet<SapVariantCopy> SapVariantCopy { get; set; }
        public DbSet<WindowsSimple> WindowsSimple { get; set; }

        public async Task CreateSapSimple(SapSimple sapSimple)
        {
            SapSimple.AddAsync(sapSimple);
        }

        public async Task CreateUnixGeneral(UnixGeneral unixGeneral)
        {
            UnixGeneral.AddAsync(unixGeneral);
        }

        public async Task CreateSapJobBwChain(SapJobBwChain sapJobBwChain)
        {
            SapJobBwChains.AddAsync(sapJobBwChain);
        }


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
        

        public DbSet<AutomicObjectDesignerBack.Models.Objects.SapJobBwChain>? SapJobBwChain { get; set; }
    }
}
