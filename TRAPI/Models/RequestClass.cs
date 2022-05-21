using Newtonsoft.Json;

namespace TRAPI.Models
{
    public class RequestClass : Station
    {
        public decimal Price { get; set; }
        public new ICollection<Data> Data { internal get; set; } = null!;
        public RequestClass GetPrice(string fuel)
        {
            Price = Data.FirstOrDefault(data => data.Name == fuel)?.Price ?? 0;
            return this;
        }
    }
}
