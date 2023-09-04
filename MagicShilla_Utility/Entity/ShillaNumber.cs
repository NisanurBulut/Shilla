using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShilla_Utility.Entity
{
    public class ShillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShillaNo { get; set; }

        [ForeignKey("Shilla")]
        public int ShillaID { get; set; }
        public Shilla Shilla { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
