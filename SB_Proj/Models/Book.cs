using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB_Proj.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Amount { get; set; }
    }
}
