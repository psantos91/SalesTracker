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

        public DateTime VisitDate { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public bool Present { get; set; }

        public DateTime FollowUp { get; set; }

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
