using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Team
    {
        [Required]
        public int TeamId { get; set; }
        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Established Date")]
        public DateTime? EstablishedDate { get; set; }
    }
}
