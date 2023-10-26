using System.ComponentModel.DataAnnotations;

namespace WebAPIPrimopunto.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [Range(typeof(DateTime), "01/01/1900", "31/12/2005", ErrorMessage = "Il cliente deve essere maggiorenne.")]
        public DateTime DataDiNascita { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(12)]
        [RegularExpression(@"^(?=(.*[A-Z]){3})(?=(.*[0-9]){4})(?=(.*[a-z]){3})(?=(.*[@#!&%]){2})")]
        public string Password { get; set; }


        [StringLength(16)]
        public string token { get; set; }
        public DateTime dataGenerato { get; set; }


    }
}
