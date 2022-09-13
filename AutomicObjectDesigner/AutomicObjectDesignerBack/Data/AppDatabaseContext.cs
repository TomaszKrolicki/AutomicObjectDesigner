﻿using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesigner.Models.Registration;
using AutomicObjectDesignerBack.Data.Configurations;
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

        public DbSet<UserModel> Users { get; set; }
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            
        }
        

        public DbSet<AutomicObjectDesignerBack.Models.Objects.SapJobBwChain>? SapJobBwChain { get; set; }
    }
}
