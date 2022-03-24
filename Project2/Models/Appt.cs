using System;
using System.ComponentModel.DataAnnotations;
namespace Project2.Models
{
    public class Appt
    {
        [Key]
        [Required]
        public long ApptId { get; set; }
        [Required]
        public DateTime ApptDate { get; set; }
        [Required]
        public int ApptTime { get; set; }
    }
}



       
