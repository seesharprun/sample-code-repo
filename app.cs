using Microsoft.Azure.Cosmos;

using CosmosClient client = new("<cosmos-connection-string>");

Database database = await client.CreateDatabaseIfNotExistsAsync("<database-name>");