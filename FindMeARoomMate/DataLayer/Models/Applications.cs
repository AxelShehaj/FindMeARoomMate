using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomMate.DataLayer.Models
{
    public class Applications
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [ForeignKey("Aplicant")]
        public int StudentId { get; set; }
        public virtual Students Aplicant { get; set; }
        public int AnnouncementId { get; set; }
        [ForeignKey("AnnouncementsId")]
        public virtual Announcements Announcements { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
