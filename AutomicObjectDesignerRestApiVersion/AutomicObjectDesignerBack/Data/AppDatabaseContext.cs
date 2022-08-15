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
        //DbSet<AutomicObject> AutomicObjects { get; set; }
    }
}
