using System.ComponentModel.DataAnnotations;

namespace WebAPIPrimopunto.Entities
{
    public class Carrello
    {
        [Required]
        public int IdCarrello { get; set; }
        [Required]
        public int IdentificativoCliente { get; set; }
        [Required]
        public int IdentificativoProdotto { get; set; }
        [Required]
        public int Quantità { get; set; }
        [Required]
        public decimal Prezzo { get; set; }

    }
}
