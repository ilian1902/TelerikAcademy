namespace PetStore.Importer
{
    using System;
    using PetStore.Data;

    public class CountryDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var lenght = random.GetRandomNumber(5, 50);
            var country = new Country { Country1 = random.GetRandomString(lenght) };
            
        }
    }
}
