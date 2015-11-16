namespace PetStore.Importer
{
    using PetStore.Data;
    using PetStore.Importer;

    public class CategoryDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var category = new Category { Name = random.GetRandomString(random.GetRandomNumber(5, 50)) };
                data.Categories.Add(category);
            }
        }
    }
}
