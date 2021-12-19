using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace harrinetCosmoApp
{
    class Program
    {
        private static readonly string _endpointUri = "https://harrinetcosmo.documents.azure.com:443/";
        private static readonly string _primaryKey = "Iiv5jX0tKoXlzxslAYYTwOMfwX1AKMGiFissrYuF3so6Oo6AGctC5qcxEzyXHuncnk0PAn8Cp7xj0V6GC9OMdg==";

        public static async Task Main(string[] args)
        {         
            using (CosmosClient client = new CosmosClient(_endpointUri, _primaryKey))
            {        
                DatabaseResponse databaseResponse = await client.CreateDatabaseIfNotExistsAsync("Products");
                Database targetDatabase = databaseResponse.Database;
                await Console.Out.WriteLineAsync($"Database Id:\t{targetDatabase.Id}");
            }
        }
    }
}
