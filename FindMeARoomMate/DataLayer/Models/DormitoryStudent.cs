using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomMate.DataLayer.Models
{
    public class DormitoryStudent
    {
        [Key]
        [Required]
        public int Id { get; set; }


        [Display(Name = "Dormitory")]
        public virtual int DormitoryId { get; set; }

        [ForeignKey("DormitoryId")]
        public virtual Dormitories Dormitories { get; set; }


        [Display(Name = "")]
        public virtual int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Students Students { get; set; }

        [Required]
        public int? Capacity { get; set; }
    }
}
