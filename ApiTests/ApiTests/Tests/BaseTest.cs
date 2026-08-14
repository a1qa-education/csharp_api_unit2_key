using Bogus;
using RestSharp;
using ApiTests.Constants;
using ApiTests.Models;

namespace ApiTests.Tests
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
            // Clear the list after teardown for consistency with the other language tracks -
            // NUnit creates a fresh instance per test by default so this isn't a live bug here,
            // but leaving stale ids around is still misleading if that default ever changes.
            CreatedPetsIds.Clear();
        }

        private void DeletePetById(long id)
        {
            // TODO: Implement delete pet by id logic
        }
    }
}
