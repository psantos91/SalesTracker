using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    public class Seller
    {
        //PROPERTIES
        [Key]
        public int SellerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Contact { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string WorkingRegion { get; set; }

        public float BaseSalary { get; set; }

        public ICollection<Client> Clients { get; set; } = new List<Client>();


        //CONTRUCTORS
        public Seller() { }

        public Seller(int sellerId, string firstName, string lastName, int contact, string email, DateTime birthDate, string workingRegion, float baseSalary)
        {
            SellerId = sellerId;
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
            Email = email;
            BirthDate = birthDate;
            WorkingRegion = workingRegion;
            BaseSalary = baseSalary;
        }

        //METHODS
        public void AddClient(Client cl)
        {
            Clients.Add(cl);
        }

        public void RemoveClient(Client cl)
        {
            Clients.Remove(cl);
        }
    }
}
