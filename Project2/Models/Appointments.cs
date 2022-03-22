using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Appointments
    {
        [Key]
        [Required]
        public long ApptId { get; set; }
        [Required]
        public string groupName { get; set; }
        [Required]
        [MaxLength(15)] // I think this is right...
        public int groupSize { get; set; }
        [Required]
        public string Email { get; set; }
 
        public string Phone { get; set; }
    }
}

