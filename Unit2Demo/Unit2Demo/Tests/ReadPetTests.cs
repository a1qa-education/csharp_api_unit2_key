using Bogus;
using RestSharp;
using System.Net;
using System.Text.Json;
using Unit2Demo.Constants;
using Unit2Demo.Models;

namespace Unit2Demo.Tests
{
    public class ReadPetTests : BaseTest
    {
        [Test]
        [Description("Get a pet by id - 200 Success")]
        public void GetPetByIdTests()
        {
            // TODO: Create POST request to add a new pet
            // TODO: Send POST request and get response
            // TODO: Assert status code is 200
            // TODO: Deserialize response and extract created pet id
            // TODO: Add created pet id to delete list

            // TODO: (Optional) Wait for pet to be saved before accessing it

            // TODO: Create GET request to retrieve pet by id
            // TODO: Send GET request and get response
            // TODO: Assert status code is 200
            // TODO: Deserialize response and assert pet name matches the original
        }

        [Test]
        [Description("Get a pet by non-existing id - 404 Not Found")]
        public void GetNonExistingPetById()
        {
            // TODO: Generate a random non-existing pet id

            // TODO: Create GET request with non-existing id
            // TODO: Send GET request and get response
            // TODO: Assert status code is 404

            // TODO: Parse response and extract error message
            // TODO: Assert error message is "Pet not found"
        }

        [Test]
        [Description("Get a pet by invalid id (string instead of int64) - 400 Bad Request")]
        [Ignore("DEFECT-001: status code 404 instead of 400 for invalid pet id")]
        public void GetPetByInvalidTypeOfId()
        {
            // TODO: Generate a random string to use as invalid id

            // TODO: Create GET request with invalid id
            // TODO: Send GET request and get response
            // TODO: Assert status code is 400
        }

    }
}