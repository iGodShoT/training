using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRAPI.Models
{
    [Table("FuelTypes")]
    public class FuelType
    {
        [Key]
        [StringLength(255)]
        public string FuelTypeID { get; set; } = null!;
    }
}
