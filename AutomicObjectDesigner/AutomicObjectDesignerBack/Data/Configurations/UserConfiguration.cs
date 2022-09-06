using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomicObjectDesigner.Models.Registration;

namespace AutomicObjectDesignerBack.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            {
                Id = 100,
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "Admin",
                Email = "admin@gmail.com",
                Password = "admin",
                HasEmailConfirmed = true,
                IsAdministrator = true
            }
        );
    }
}