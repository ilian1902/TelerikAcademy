namespace PetStore.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using Importer;
    using Data;

    public class Startup
    {
        public static void Main()
        {
            var dataGeneratorExecutors = new List<DataGeneratorExecutor>
                                             {
                                                 new DataGeneratorExecutor(new CountryDataGenerator(), 20),

                                                // new DataGeneratorExecutor(new SpeciesDataGenerator(), 100),
                                                // new DataGeneratorExecutor(new PetsDataGenerator(), 5000),
                                                // new DataGeneratorExecutor(new ProductsDataGenerator(), 400), // per category
                                                // new DataGeneratorExecutor(new CategoryDataGenerator(), 50), 
                                             };

            foreach (var dataGeneratorExecutor in dataGeneratorExecutors)
            {
                using (var data = new PetStoreEntities())
                {
                    data.Configuration.AutoDetectChangesEnabled = false;
                    data.Configuration.ProxyCreationEnabled = false;

                    Console.WriteLine("Staring {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    dataGeneratorExecutor.Execute(data, RandomGenerator.Instance);
                    Console.WriteLine("Saving {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    data.SaveChanges();
                    Console.WriteLine("Finished {0}.", dataGeneratorExecutor.DataGenerator.GetType().Name);
                }
            }
        }
    }
}
