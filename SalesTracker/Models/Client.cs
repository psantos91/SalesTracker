using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    public class Client
    {
        //PROPERTIES
        [Key]
        public int ClientId { get; set; }

        [Display(Name = "Empresa")]
        public string CompanyName { get; set; }

        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Morada Exploração")]
        public string FarmAddress { get; set; }

        [Display(Name = "Morada Faturação")]
        public string BillingAddress { get; set; }

        [Display(Name = "Contacto")]
        public int Contact { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "NIF")]
        public int NIF { get; set; }

        [Display(Name = "Cultura Principal")]
        public string MainCrop { get; set; }

        [Display(Name = "Cultura Secundária")]
        public string SecondaryCrop { get; set; }

        [Display(Name = "Área Exploração")]
        public double FarmArea { get; set; }

        [Display(Name = "Comprador")]
        public bool HasBought { get; set; }

        [Display(Name = "Rating")]
        [Range(1,5)]
        public int Rating { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();


        //CONSTRUCTORS
        public Client() { }

        public Client(int clientId, string companyName, string firstName, string lastName, string farmAddress, string billingAddress, int contact, string email, int nif, string mainCrop, string secondaryCrop, float farmArea, bool hasBought, int rating, int sellerId)
        {
            ClientId = clientId;
            CompanyName = companyName;
            FirstName = firstName;
            LastName = lastName;
            FarmAddress = farmAddress;
            BillingAddress = billingAddress;
            Contact = contact;
            Email = email;
            NIF = nif;
            MainCrop = mainCrop;
            SecondaryCrop = secondaryCrop;
            FarmArea = farmArea;
            HasBought = hasBought;
            Rating = rating;
            SellerId = sellerId;
        }

        //METHODS
        public void AddVisit(Visit vs)
        {
            Visits.Add(vs);
        }

        public void RemoveVisit(Visit vs)
        {
            Visits.Remove(vs);
        }
    }
}
