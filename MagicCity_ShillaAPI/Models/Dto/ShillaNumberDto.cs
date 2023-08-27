using System.ComponentModel.DataAnnotations;

namespace MagicCity_ShillaAPI.Models.Dto
{
    public class ShillaNumberDto
    {
        [Required]
        public int ShillaNo { get; set; } = 0;
        public string Details { get; set; }
    }
}
