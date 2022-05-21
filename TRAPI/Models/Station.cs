using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRAPI.Models
{
    [Table("Stations")]
    public class Station
    {
        [Key]
        public int Station_ID { get; set; }
        public string Address { get; set; } = null!;
        [ForeignKey(nameof(Station_ID))]
        public virtual ICollection<Data> Data { get; set; }

        public Station()
        {
            Data = new List<Data>();
        }
        
    }
}
