using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApiFaseB.Entities
{
    public class Utente
    {
        
         //Bson annotations
          [BsonId]
          [BsonRepresentation(BsonType.ObjectId)]
          public String?UtenteId { get; set; }
        [BsonElement("UtenteName")]
        public string? UtenteName { get; set; }
            
        

    }
}
