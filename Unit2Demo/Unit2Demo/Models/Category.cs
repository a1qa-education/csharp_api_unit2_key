using System.Text.Json.Serialization;

namespace Unit2Demo.Models
{
    public record Category
    (
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("name")] string? Name = null
    );

}
