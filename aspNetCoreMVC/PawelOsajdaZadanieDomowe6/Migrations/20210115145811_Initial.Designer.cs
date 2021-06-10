﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PawelOsajdaZadanieDomowe6.Models;

namespace PawelOsajdaZadanieDomowe6.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210115145811_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.GraphicsCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VRamAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GraphicsCards");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GraphicsCardId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProcessorId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RamAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GraphicsCardId");

                    b.HasIndex("ProcessorId");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserInformationsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("UserInformationsId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Processor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfThreds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Suborder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LaptopId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LaptopId");

                    b.HasIndex("OrderId");

                    b.ToTable("Suborders");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserInformationsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserInformationsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.UserInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Laptop", b =>
                {
                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.GraphicsCard", "GraphicsCard")
                        .WithMany("Laptops")
                        .HasForeignKey("GraphicsCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.Processor", "Processor")
                        .WithMany("Laptops")
                        .HasForeignKey("ProcessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Order", b =>
                {
                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryId");

                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.UserInformations", "UserInformations")
                        .WithMany()
                        .HasForeignKey("UserInformationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.Suborder", b =>
                {
                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.Laptop", "Laptop")
                        .WithMany("Suborders")
                        .HasForeignKey("LaptopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.Order", "Order")
                        .WithMany("Suborders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PawelOsajdaZadanieDomowe6.Models.Entities.User", b =>
                {
                    b.HasOne("PawelOsajdaZadanieDomowe6.Models.Entities.UserInformations", "UserInformations")
                        .WithMany("User")
                        .HasForeignKey("UserInformationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
