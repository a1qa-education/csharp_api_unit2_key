using RestSharp;
using ApiTests.Constants;
using ApiTests.Models;

namespace ApiTests.Tests
{
    public class UpdatePetTests : BaseTest
    {
        [Test]
        [Description("Test Case 3 - Update a Pet")]
        public void UpdatePetTest()
        {
            // TODO: create the pet; assert status code and add its id to CreatedPetsIds for teardown

            // TODO: update the pet's category via PUT; assert status code and the response category name

            // TODO: retrieve the pet again and assert its category name matches the update
        }
    }
}
