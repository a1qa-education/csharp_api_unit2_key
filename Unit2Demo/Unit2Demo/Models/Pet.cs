using System.Text.Json.Serialization;

namespace Unit2Demo.Models
{
    public record Pet
    (
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("category")] Category? Category = null,
     [property: JsonPropertyName("name")] string? Name = null,
     [property: JsonPropertyName("photoUrls")] List<string>? PhotoUrls = null,
     [property: JsonPropertyName("tags")] List<Tag>? Tags = null,
     [property: JsonPropertyName("status")] string? Status = null
    );

}
