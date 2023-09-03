using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomMate.DataLayer.Models
{
    public class Students
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string? FullName { get; set; }
    }
}
