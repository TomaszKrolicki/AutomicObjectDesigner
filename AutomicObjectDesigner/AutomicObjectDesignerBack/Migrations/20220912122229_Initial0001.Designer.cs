﻿// <auto-generated />
using System;
using AutomicObjectDesignerBack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    [DbContext(typeof(AppDatabaseContext))]
    [Migration("20220912122229_Initial0001")]
    partial class Initial0001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutomicObjectDesigner.Models.Objects.FileTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FileTransfers");
                });

            modelBuilder.Entity("AutomicObjectDesigner.Models.Objects.LinuxSimple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LinuxSimple");
                });

            modelBuilder.Entity("AutomicObjectDesigner.Models.Objects.SapSimple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("DeleteSapJob")
                        .HasColumnType("bit");

                    b.Property<string>("Documentation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("RoutineJob")
                        .HasColumnType("bit");

                    b.Property<string>("SapClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapJobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapReport1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapSid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapVariant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapVariant1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SapSimple");
                });

            modelBuilder.Entity("AutomicObjectDesigner.Models.Objects.SapVariantCopy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SapVariantCopy");
                });

            modelBuilder.Entity("AutomicObjectDesigner.Models.Objects.WindowsSimple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Archive1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Archive2")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Docu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("InternalAccount")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<string>("NameSuffix")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ObjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("WindowsSimple");
                });

            modelBuilder.Entity("AutomicObjectDesigner.Models.Registration.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<bool>("HasEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            HasEmailConfirmed = true,
                            IsAdministrator = true,
                            LastName = "Admin",
                            Password = "Admin!11",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("AutomicObjectDesignerBack.Models.Objects.SapJobBwChain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DeleteSapJob")
                        .HasColumnType("bit");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Kette")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RoutineJob")
                        .HasColumnType("bit");

                    b.Property<string>("SapClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapJobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapReport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapSid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapVariant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SapJobBwChain");
                });

            modelBuilder.Entity("AutomicObjectDesignerBack.Models.Objects.UnixGeneral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folder")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParallelTasks")
                        .HasColumnType("int");

                    b.Property<string>("NameSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Queue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RoutineJob")
                        .HasColumnType("bit");

                    b.Property<string>("SapClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SapSid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnixLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnixServer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnixGeneral");
                });
#pragma warning restore 612, 618
        }
    }
}
