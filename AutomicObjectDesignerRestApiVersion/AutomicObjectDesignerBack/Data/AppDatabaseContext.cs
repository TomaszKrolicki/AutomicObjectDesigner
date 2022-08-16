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


    }
}
