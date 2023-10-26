using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApiFaseB.Entities
{
    public class Carrello
    {
        

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? IdCarrello { get; set; }

        public Utente id { get; set; }


    }
}
