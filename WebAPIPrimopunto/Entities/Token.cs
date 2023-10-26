using System.ComponentModel.DataAnnotations;

namespace WebAPIPrimopunto.Entities
{
    public class Token
    {
        [StringLength(16)]
        public string token { get; set; }
        public DateTime dataGenerato { get; set; }



    }
}
