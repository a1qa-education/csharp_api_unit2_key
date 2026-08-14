namespace ApiTests.Constants
{
    public static class Endpoints
    {
        public const string PetIdParameter = "petId";

        public const string Pet = "/pet";

        public static readonly string PetById = Pet + UrlSegmentParameter(PetIdParameter);

        // Test Case 5 (bearer auth against httpbin.org) is written from scratch -
        // add the httpbin.org base URL/endpoint yourself as part of that test.

        private static string UrlSegmentParameter(string parameterName) => "/{" + parameterName + "}";
    }
}
