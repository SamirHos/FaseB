using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace WebApiFaseB.Entities
{
    public class Prodotto
    {

        //Bson annotations
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? ProductId { get; set; }
        [BsonElement("ProductName")]
        public string? Nome { get; set; }
        public Utente utente { get; set; }
        public Carrello carrello { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Giacenza { get; set; }
    }

}

    

