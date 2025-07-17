using Bogus.Bson;
using RestSharp;
using System.Net;
using System.Text.Json;
using Unit2Demo.Constants;
using Unit2Demo.Models;

namespace Unit2Demo.Tests
{
    public class CreatePetTests : BaseTest
    {
        [Test]
        [Description("Create a pet - 200 Success")]
        public void CreatePetTest()
        {
            // TODO: Make post pet request            

            // TODO: Assert status code and content type
            
            // TODO: Assert allowMethods header

            // TODO: Get id and name of the created pet

            // TODO: Add created pet id to delete list
            // CreatedPetsIds.Add(createdPetId);

            // TODO: Assert name is correct
        }

        [Test]
        [Description("Create a pet using PUT - 200 Success")]
        public void CreatePetUsingPut()
        {
            // TODO: Create PUT request with generated pet data

            // TODO: Send PUT request and get response

            // TODO: Assert status code is 200

            // TODO: Parse response JSON and extract pet id and name

            // TODO: Add created pet id to delete list

            // TODO: Assert pet name matches the generated name


            // Wait for pet to be saved before accessing it

            // TODO: Create GET request to retrieve pet by id

            // TODO: Send GET request and get response

            // TODO: Assert status code is 200

            // TODO: Deserialize response and assert pet name matches
        }

    }
}