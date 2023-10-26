using MongoDB.Driver;
using WebApiFaseB.Entities;

namespace WebApiFaseB.DataAccess
{
    public interface INegozioContext
    {
         
        IMongoCollection<Prodotto> Prodotti { get; }
    }

}

