using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Group
    {
        [Key]
        [Required]
        public long GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1,15, ErrorMessage = "Group size must be between 1-15")]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public Appt Appt { get; set; }
        public int ApptId { get; set; }

    }
}

