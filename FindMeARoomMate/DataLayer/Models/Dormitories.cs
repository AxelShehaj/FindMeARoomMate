using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomMate.DataLayer.Models
{
    public class Dormitories
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? MaxCapacity { get; set; }
    }
}
