namespace PetStore.Importer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PetStore.Data;

    public class PetsDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var allAddedPets = new List<Pet>();
            var departmentIds = data.Pets.Select(p => p.PetsID).ToList();

            
        }
    }
}
