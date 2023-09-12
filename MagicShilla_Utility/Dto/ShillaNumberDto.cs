using MagicShilla_Utility.Entity;
using System.ComponentModel.DataAnnotations;

namespace MagicShilla_Utility.Dto
{
    public class ShillaNumberDto
    {
        [Required]
        public int ShillaNo { get; set; } = 0;
        public int ShillaID { get; set; }
        public ShillaDto Shilla { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
