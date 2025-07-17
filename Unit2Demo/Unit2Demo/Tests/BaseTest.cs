using Bogus;
using RestSharp;
using Unit2Demo.Constants;
using Unit2Demo.Models;

namespace Unit2Demo.Tests
{
    public abstract class BaseTest
    {
        protected RestClient PetStoreApiClient;

        protected List<long> CreatedPetsIds = new List<long>();
        protected Pet GeneratedPet;

        [OneTimeSetUp]
        public void SetUpApiClient()
        {
            var restClientOptions = new RestClientOptions()
            {
                BaseUrl = new Uri(PetStoreApiSettings.ApiUrl + PetStoreApiSettings.BaseApiPath),
            };
            PetStoreApiClient = new RestClient(restClientOptions);
        }

        [OneTimeTearDown]
        public void TearDownApiClient()
        {
            PetStoreApiClient?.Dispose();
        }

        [SetUp]
        public void GeneratePetWithRandomName()
        {
            // GeneratedPet = ...
            // TODO: Generate Pet With Random Name
        }

        [TearDown]
        public void DeleteCreatedPets()
        {
            foreach (long id in CreatedPetsIds)
            {
                DeletePetById(id);
            }
        }

        private void DeletePetById(long id)
        {
            // TODO: Implement delete pet by id logic
        }
    }
}
