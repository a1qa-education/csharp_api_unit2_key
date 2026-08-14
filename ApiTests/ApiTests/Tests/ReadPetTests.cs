using RestSharp;
using ApiTests.Constants;
using ApiTests.Models;

namespace ApiTests.Tests
{
    public class ReadPetTests : BaseTest
    {
        [Test]
        [Description("Test Case 2 - Get a Pet by ID")]
        public void GetPetByIdTests()
        {
            // TODO: create the pet; assert status code and add its id to CreatedPetsIds for teardown

            // TODO: retrieve the pet by id and assert status code

            // TODO: assert the retrieved pet's name matches the created pet's name
        }

        [Test]
        [Description("Test Case 4 - Get a Pet by an Invalid ID")]
        // Intentionally not [Ignore]d: the documentation says 400, the real API returns 404
        // (DEFECT-001). The test must run and fail against the documented expectation.
        public void GetPetByInvalidTypeOfId()
        {
            // TODO: generate a random alphabetic id and send GET; assert status code is 400
        }
    }
}
