﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesTracker.Data;

namespace SalesTracker.Migrations
{
    [DbContext(typeof(SalesTrackerContext))]
    partial class SalesTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesTracker.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarmAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FarmArea")
                        .HasColumnType("float");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasBought")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainCrop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIF")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("SecondaryCrop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.HasIndex("SellerId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            BillingAddress = "Tocha",
                            CompanyName = "Company 1",
                            Contact = 919885411,
                            Email = "fabio@gmail.com",
                            FarmAddress = "Tocha",
                            FarmArea = 2.5,
                            FirstName = "Fabio",
                            HasBought = true,
                            LastName = "Martins",
                            MainCrop = "Morango",
                            NIF = 208458423,
                            Rating = 5,
                            SecondaryCrop = "Couve",
                            SellerId = 1
                        },
                        new
                        {
                            ClientId = 2,
                            BillingAddress = "Ventosa",
                            CompanyName = "Company 2",
                            Contact = 914586522,
                            Email = "rui@gmail.com",
                            FarmAddress = "Ventosa",
                            FarmArea = 6.0,
                            FirstName = "Rui",
                            HasBought = true,
                            LastName = "Baptista",
                            MainCrop = "Vinha",
                            NIF = 248521446,
                            Rating = 5,
                            SecondaryCrop = "Milho",
                            SellerId = 1
                        },
                        new
                        {
                            ClientId = 3,
                            BillingAddress = "Ventosa",
                            CompanyName = "Company 3",
                            Contact = 918452233,
                            Email = "paula@gmail.com",
                            FarmAddress = "Ventosa",
                            FarmArea = 16.0,
                            FirstName = "Paula",
                            HasBought = true,
                            LastName = "Almeida",
                            MainCrop = "Vinha",
                            NIF = 248753226,
                            Rating = 4,
                            SecondaryCrop = "",
                            SellerId = 1
                        },
                        new
                        {
                            ClientId = 4,
                            BillingAddress = "Vila do Conde",
                            CompanyName = "Company 4",
                            Contact = 914885622,
                            Email = "fernando@gmail.com",
                            FarmAddress = "Vila do Conde",
                            FarmArea = 1.0,
                            FirstName = "Fernando",
                            HasBought = false,
                            LastName = "Almeida",
                            MainCrop = "Alface",
                            NIF = 501458969,
                            Rating = 2,
                            SecondaryCrop = "Alho Frances",
                            SellerId = 2
                        },
                        new
                        {
                            ClientId = 5,
                            BillingAddress = "Porto",
                            CompanyName = "Company 5",
                            Contact = 914587522,
                            Email = "antonio@gmail.com",
                            FarmAddress = "Felgueiras",
                            FarmArea = 7.7999999999999998,
                            FirstName = "Antonio",
                            HasBought = true,
                            LastName = "Silva",
                            MainCrop = "Mirtilo",
                            NIF = 501245889,
                            Rating = 3,
                            SecondaryCrop = "Kiwi",
                            SellerId = 3
                        });
                });

            modelBuilder.Entity("SalesTracker.Models.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BaseSalary")
                        .HasColumnType("real");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingRegion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = 1,
                            BaseSalary = 800f,
                            BirthDate = new DateTime(1991, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Contact = 919551288,
                            Email = "paulo@gmail.com",
                            FirstName = "Paulo",
                            LastName = "Santos",
                            WorkingRegion = "Center Coast"
                        },
                        new
                        {
                            SellerId = 2,
                            BaseSalary = 900f,
                            BirthDate = new DateTime(1989, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Contact = 914558622,
                            Email = "joao@gmail.com",
                            FirstName = "Joao",
                            LastName = "Martins",
                            WorkingRegion = "North Coast"
                        },
                        new
                        {
                            SellerId = 3,
                            BaseSalary = 800f,
                            BirthDate = new DateTime(1984, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Contact = 914587533,
                            Email = "ricardo@gmail.com",
                            FirstName = "Ricardo",
                            LastName = "Casal",
                            WorkingRegion = "North"
                        });
                });

            modelBuilder.Entity("SalesTracker.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FollowUp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Present")
                        .HasColumnType("bit");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitId");

                    b.HasIndex("ClientId");

                    b.ToTable("Visits");

                    b.HasData(
                        new
                        {
                            VisitId = 1,
                            ClientId = 1,
                            FollowUp = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observations = "Apresentação de Calcário",
                            Present = true,
                            VisitDate = new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            VisitId = 2,
                            ClientId = 2,
                            FollowUp = new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observations = "Apresentação de Produtos",
                            Present = true,
                            VisitDate = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            VisitId = 3,
                            ClientId = 3,
                            FollowUp = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observations = "",
                            Present = false,
                            VisitDate = new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            VisitId = 4,
                            ClientId = 1,
                            FollowUp = new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observations = "Apresentação de Fertilizantes",
                            Present = true,
                            VisitDate = new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            VisitId = 5,
                            ClientId = 2,
                            FollowUp = new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observations = "Apresentação de Matéria Orgânica",
                            Present = true,
                            VisitDate = new DateTime(2020, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SalesTracker.Models.Client", b =>
                {
                    b.HasOne("SalesTracker.Models.Seller", "Seller")
                        .WithMany("Clients")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalesTracker.Models.Visit", b =>
                {
                    b.HasOne("SalesTracker.Models.Client", "Client")
                        .WithMany("Visits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
