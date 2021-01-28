using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesTracker.Models;

namespace SalesTracker.Data
{
    public class SalesTrackerContext : DbContext
    {
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public SalesTrackerContext(DbContextOptions<SalesTrackerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SELLER SEEDING
            modelBuilder.Entity<Seller>().HasData(
                new Seller
                {
                    SellerId = 1,
                    FirstName = "Paulo",
                    LastName = "Santos",
                    Contact = 919551288,
                    Email = "paulo@gmail.com",
                    BirthDate = new DateTime(1991, 04, 08),
                    WorkingRegion = "Center Coast",
                    BaseSalary = 800
                },
                new Seller
                {
                    SellerId = 2,
                    FirstName = "Joao",
                    LastName = "Martins",
                    Contact = 914558622,
                    Email = "joao@gmail.com",
                    BirthDate = new DateTime(1989, 05, 10),
                    WorkingRegion = "North Coast",
                    BaseSalary = 900
                },
                new Seller
                {
                    SellerId = 3,
                    FirstName = "Ricardo",
                    LastName = "Casal",
                    Contact = 914587533,
                    Email = "ricardo@gmail.com",
                    BirthDate = new DateTime(1984, 12, 27),
                    WorkingRegion = "North",
                    BaseSalary = 800
                });

            //CLIENT SEEDING
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientId = 1,
                    CompanyName = "Company 1",
                    FirstName = "Fabio",
                    LastName = "Martins",
                    FarmAddress = "Tocha",
                    BillingAddress = "Tocha",
                    Contact = 919885411,
                    Email = "fabio@gmail.com",
                    NIF = 208458423,
                    MainCrop = "Morango",
                    SecondaryCrop = "Couve",
                    FarmArea = 2.5,
                    HasBought = true,
                    Rating = 5,
                    SellerId = 1
                },
                new Client
                {
                    ClientId = 2,
                    CompanyName = "Company 2",
                    FirstName = "Rui",
                    LastName = "Baptista",
                    FarmAddress = "Ventosa",
                    BillingAddress = "Ventosa",
                    Contact = 914586522,
                    Email = "rui@gmail.com",
                    NIF = 248521446,
                    MainCrop = "Vinha",
                    SecondaryCrop = "Milho",
                    FarmArea = 6,
                    HasBought = true,
                    Rating = 5,
                    SellerId = 1
                },
                new Client
                {
                    ClientId = 3,
                    CompanyName = "Company 3",
                    FirstName = "Paula",
                    LastName = "Almeida",
                    FarmAddress = "Ventosa",
                    BillingAddress = "Ventosa",
                    Contact = 918452233,
                    Email = "paula@gmail.com",
                    NIF = 248753226,
                    MainCrop = "Vinha",
                    SecondaryCrop = "",
                    FarmArea = 16,
                    HasBought = true,
                    Rating = 4,
                    SellerId = 1
                },
                new Client
                {
                    ClientId = 4,
                    CompanyName = "Company 4",
                    FirstName = "Fernando",
                    LastName = "Almeida",
                    FarmAddress = "Vila do Conde",
                    BillingAddress = "Vila do Conde",
                    Contact = 914885622,
                    Email = "fernando@gmail.com",
                    NIF = 501458969,
                    MainCrop = "Alface",
                    SecondaryCrop = "Alho Frances",
                    FarmArea = 1,
                    HasBought = false,
                    Rating = 2,
                    SellerId = 2
                },
                new Client
                {
                    ClientId = 5,
                    CompanyName = "Company 5",
                    FirstName = "Antonio",
                    LastName = "Silva",
                    FarmAddress = "Felgueiras",
                    BillingAddress = "Porto",
                    Contact = 914587522,
                    Email = "antonio@gmail.com",
                    NIF = 501245889,
                    MainCrop = "Mirtilo",
                    SecondaryCrop = "Kiwi",
                    FarmArea = 7.8,
                    HasBought = true,
                    Rating = 3,
                    SellerId = 3
                });

            modelBuilder.Entity<Visit>().HasData(
                new Visit
                {
                    VisitId = 1,
                    VisitDate = new DateTime(2020,12,30),
                    ClientId = 1,
                    Present = true,
                    FollowUp = new DateTime(2021,02,15),
                    Observations = "Apresentação de Calcário"
                },
                new Visit
                {
                    VisitId = 2,
                    VisitDate = new DateTime(2020, 12, 10),
                    ClientId = 2,
                    Present = true,
                    FollowUp = new DateTime(2021, 01, 31),
                    Observations = "Apresentação de Produtos"
                },
                new Visit
                {
                    VisitId = 3,
                    VisitDate = new DateTime(2020, 12, 30),
                    ClientId = 3,
                    Present = false,
                    FollowUp = new DateTime(2021, 02, 01),
                    Observations = ""
                },
                new Visit
                {
                    VisitId = 4,
                    VisitDate = new DateTime(2020, 12, 29),
                    ClientId = 1,
                    Present = true,
                    FollowUp = new DateTime(2021, 02, 10),
                    Observations = "Apresentação de Fertilizantes"
                },
                new Visit
                {
                    VisitId = 5,
                    VisitDate = new DateTime(2020, 12, 27),
                    ClientId = 2,
                    Present = true,
                    FollowUp = new DateTime(2021, 02, 07),
                    Observations = "Apresentação de Matéria Orgânica"
                }
                );
        }
    }
}
