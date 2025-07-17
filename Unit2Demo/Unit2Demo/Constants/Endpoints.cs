namespace Unit2Demo.Constants
{
    public static class Endpoints
    {
        public const string PetIdParameter = "petId";
        public const string OrderIdParameter = "orderId";

        public const string Pet = "/pet";                
        public const string Store = "/store";
        public const string Order = Store + "/order";

        public static readonly string PetById = Pet + UrlSegmentParameter(PetIdParameter);
        public static readonly string OrderById = Order + UrlSegmentParameter(OrderIdParameter);

        // httpbin.org endpoints
        public const string Bearer = "/bearer";
        public static string BasicAuth(string user, string password) => $"/basic-auth/{user}/{password}";

        private static string UrlSegmentParameter(string parameterName) => "/{" + parameterName + "}";
    }
}
