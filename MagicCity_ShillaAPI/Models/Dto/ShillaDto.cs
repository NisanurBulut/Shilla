using System.ComponentModel.DataAnnotations;

namespace MagicCity_ShillaAPI.Models.Dto
{
    public class ShillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
