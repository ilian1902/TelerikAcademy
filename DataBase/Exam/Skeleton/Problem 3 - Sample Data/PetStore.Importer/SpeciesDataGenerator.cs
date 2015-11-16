namespace PetStore.Importer
{
    using System.Collections.Generic;
    using PetStore.Data;

    public class SpeciesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var uniqueNames = new HashSet<string>();

            while (uniqueNames.Count < count)
            {
                uniqueNames.Add(random.GetRandomString(random.GetRandomNumber(10, 50)));
            }

            foreach (var uniqueName in uniqueNames)
            {
                var specie = new Species {  };
                data.Species.Add(specie);
            }
        }
    }
}
