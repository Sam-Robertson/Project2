using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public long ApptId { get; set; }
        [Required]
        public string groupName { get; set; }
        [Required]
        [Range(1,15, ErrorMessage = "Group size must be between 1-15")]
        public int groupSize { get; set; }
        [Required]
        public string Email { get; set; }
 
        public string Phone { get; set; }
    }
}

