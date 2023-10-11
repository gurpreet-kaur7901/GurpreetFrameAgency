using System;
using System.ComponentModel.DataAnnotations;

namespace GurpreetFrameAgency.Models
{
    public class Frame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string Color { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}