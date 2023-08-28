using System.ComponentModel.DataAnnotations;

namespace MagicCity_ShillaAPI.Models.Dto
{
    public class ShillaNumberCreateDto
    {
        [Required]
        public int ShillaNo { get; set; } = 0;
        public string Details { get; set; }
        [Required]
        public int ShillaID { get; set; }
    }
}
