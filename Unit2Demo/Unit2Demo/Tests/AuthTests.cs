using Bogus;
using RestSharp;
using RestSharp.Authenticators;
using System.Buffers.Text;
using System.Net;
using Unit2Demo.Constants;

namespace Unit2Demo.Tests;

public class AuthTests
{
    private const string ApiUrl = "https://httpbin.org";

    [Test]
    [Description("Log in with basic auth - 200 Success")]
    public void LogInWithBasicAuth()
    {
        var faker = new Faker();
        string username = faker.Internet.UserName();
        string password = faker.Internet.Password();

        var clientOptions = new RestClientOptions
        {
            BaseUrl = new Uri(ApiUrl),
            Authenticator = new HttpBasicAuthenticator(username, password)
        };
        var client = new RestClient(clientOptions);
        var request = new RestRequest(Endpoints.BasicAuth(username, password));
        RestResponse response = client.Get(request);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Status code is not 200");
    }

    [Test]
    [Description("Log in with a bearer token - 200 Success")]
    public void LogInWithBearerToken()
    {
        string token = new Faker().Random.Word();

        var clientOptions = new RestClientOptions
        {
            BaseUrl = new Uri(ApiUrl),
            Authenticator = new JwtAuthenticator(token)
        };
        var client = new RestClient(clientOptions);
        var request = new RestRequest(Endpoints.Bearer);
        RestResponse response = client.Get(request);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Status code is not 200");
    }
}