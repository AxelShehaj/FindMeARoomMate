using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomMate.DataLayer.Models
{
    public class Announcements
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime? PublishedDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
