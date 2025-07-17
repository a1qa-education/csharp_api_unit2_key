using System.Text.Json.Serialization;

namespace Unit2Demo.Models
{
    public record Order
    (
     [property: JsonPropertyName("petId")] long? PetId = null,
     [property: JsonPropertyName("quantity")] int? Quantity = null,
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("shipDate")] string? ShipDate = null,
     [property: JsonPropertyName("complete")] bool? Complete = null,
     [property: JsonPropertyName("status")] string? Status = null
    );

}
