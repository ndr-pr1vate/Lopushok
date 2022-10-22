using Newtonsoft.Json;

namespace Lopushok.Models
{
    public class ChangeCountModel
    {
        [JsonProperty(PropertyName = "product_id")]
        public int ProductId { get; set; }

        [JsonProperty(PropertyName = "add")]
        public int Add { get; set; }
    }
}