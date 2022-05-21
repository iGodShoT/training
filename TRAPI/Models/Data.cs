using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TRAPI.Models
{
    public class Data
    {
        [Key]
        [JsonIgnore]
        public int ID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AmountOfFuel { get; set; }
        [JsonIgnore]
        public int Station_ID { get; set; }
    }
}
