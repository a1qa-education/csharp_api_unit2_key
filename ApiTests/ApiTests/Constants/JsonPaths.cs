namespace ApiTests.Constants
{
    // Use these only for trivial single-field lookups (e.g. grabbing the created
    // pet's id right after a POST). For anything with nested fields - like a pet's
    // category name - deserialize the response into a Model class and assert on
    // that instead of chaining JsonPath lookups (e.g. avoid
    // response.Content.JsonPath("category.name")-style assertions). See the
    // "Deserialization over JSONPath" requirement.
    public static class JsonPaths
    {
        public const string Id = "id";
        public const string Name = "name";
        public const string Message = "message";
    }
}
