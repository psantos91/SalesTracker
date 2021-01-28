using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    public class Visit
    {
        //PROPERTIES
        [Key]
        public int VisitId { get; set; }

        [Display(Name = "Data Visita")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "Presente")]
        public bool Present { get; set; }

        [Display(Name = "Data Follow Up")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FollowUp { get; set; }

        [Display(Name = "Observações")]
        public string Observations { get; set; }


        //CONSTRUCTORS
        public Visit() { }

        public Visit(int visitId, DateTime visitDate, int clientId, bool present, DateTime followUp, string observations)
        {
            VisitId = visitId;
            VisitDate = visitDate;
            ClientId = clientId;
            Present = present;
            FollowUp = followUp;
            Observations = observations;
        }
    }
}
