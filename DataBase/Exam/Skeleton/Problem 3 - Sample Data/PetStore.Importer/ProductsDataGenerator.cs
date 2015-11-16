namespace PetStore.Importer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PetStore.Data;

    public class ProductsDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var speciesID = data.Species.Select(s => s.SpeciesID).ToList().ToString();
            var product = new Product
            {
                ProductName = random.GetRandomString(25),
                Price = random.GetRandomNumber(10, 1000),
            };

            foreach (var species in speciesID)
            {
                
            }
        }
    }
}