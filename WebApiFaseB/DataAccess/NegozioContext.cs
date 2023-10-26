using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApiFaseB.Entities;
using WebApiFaseB.Model;

namespace WebApiFaseB.DataAccess
{
    public class NegozioContext : INegozioContext
    {

        NegozioDatabaseSettingsClass _settings;
        public NegozioContext(IOptions<NegozioDatabaseSettingsClass> negozioDatabaseSettingsClass)
        {
            var client = new MongoClient(negozioDatabaseSettingsClass.Value.ConnectionString);
            var database = client.GetDatabase(negozioDatabaseSettingsClass.Value.DatabaseName);
            Prodotti = database.GetCollection<Prodotto>(negozioDatabaseSettingsClass.Value.CollectionName);

        }
        public IMongoCollection<Prodotto> Prodotti { get; }
    }
}

