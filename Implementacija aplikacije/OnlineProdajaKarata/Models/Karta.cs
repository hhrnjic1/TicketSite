using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineProdajaKarata.Models
{
    public class Karta
    {
        [Key]
        public int IdKarte { get; set; }

        [ForeignKey("User")]
        public int IDUser { get; set; }

        [ForeignKey("Manifestacija")]
        public int IDManifestacije { get; set; }
        public String KodKarte { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int Kolicina { get; set; }
    }
}
