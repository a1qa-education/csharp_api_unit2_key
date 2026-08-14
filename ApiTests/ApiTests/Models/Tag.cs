using System.Text.Json.Serialization;

namespace ApiTests.Models
{
    public record Tag
    (
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("name")] string? Name = null
    );

}
