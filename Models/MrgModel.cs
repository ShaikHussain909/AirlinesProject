using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2d.Models
{
    public class MrgModel
    {
        [Key]
        public int FCode { get; set; }

        [Required(ErrorMessage = "Flight Name is required")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Source is required")]
        public string Source { get; set; }

        [Required(ErrorMessage = "Destination is required")]
        public string Destination { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string Arrival { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Departure { get; set; }
        [Required]
        public int Exe_Seats { get; set; }
        [Required]
        public decimal Exe_Fare { get; set; }
        [Required]
        public int Eco_Seats { get; set; }
        [Required]
        public decimal Eco_Fare { get; set; }
        [Required]
        public int Bus_Seats { get; set; }
        [Required]
        public decimal Bus_Fare { get; set; }

    }
}

    