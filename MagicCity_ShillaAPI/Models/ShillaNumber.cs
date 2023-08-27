using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicCity_ShillaAPI.Models
{
    public class ShillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShillaNo { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
