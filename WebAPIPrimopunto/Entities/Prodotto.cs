using System.ComponentModel.DataAnnotations;

namespace WebAPIPrimopunto.Entities
{
    public class Prodotto
    {


        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Giacenza { get; set; }

        [Required]
        public decimal Prezzo { get; set; }
    }
}
