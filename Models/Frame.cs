using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GurpreetFrameAgency.Models
{
    public class Frame
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 6)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 6)]
        [Required]
        public string Type { get; set; }
        [Display(Name = "Manufacturing Date")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        [StringLength(60, MinimumLength = 6)]
        [Required]
        public string Color { get; set; }
        [RegularExpression(@"^[1-5]*$")]
        [StringLength(1)]
        [Required]
        public int Rating { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}