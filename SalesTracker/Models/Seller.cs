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

        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Contacto")]
        public int Contact { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Região")]
        public string WorkingRegion { get; set; }

        [Display(Name = "Salário Base")]
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
