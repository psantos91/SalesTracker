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

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FarmAddress { get; set; }

        public string BillingAddress { get; set; }

        public int Contact { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int NIF { get; set; }

        public string MainCrop { get; set; }

        public string SecondaryCrop { get; set; }

        public double FarmArea { get; set; }

        public bool HasBought { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }


        //CONSTRUCTORS
        public Client() { }

        public Client(int clientId, string companyName, string firstName, string lastName, string farmAddress, string billingAddress, int contact, string email, int nif, string mainCrop, string secondaryCrop, float farmArea, bool hasBought, int rating, int sellerId, Seller seller)
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
    }
}
