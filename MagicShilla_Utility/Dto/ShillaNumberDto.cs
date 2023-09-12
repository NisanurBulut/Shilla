using System.ComponentModel.DataAnnotations;

namespace MagicShilla_Utility.Dto
{
    public class ShillaNumberDto
    {
        [Required]
        public int ShillaNo { get; set; } = 0;
        public string Details { get; set; }
        [Required]
        public int ShillaID { get; set; }
        public ShillaDto Shilla { get; set; }
    }
}
