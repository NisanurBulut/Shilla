using System.ComponentModel.DataAnnotations;

namespace MagicShilla_Utility.Dto
{
    public class CreateShillaDto
    {
     
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }

        public DateTime CreatedAt = DateTime.Now;
    }
}
