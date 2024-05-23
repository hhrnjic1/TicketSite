using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineProdajaKarata.Models
{
    public class KupljenaMjesta
    {
        [Key]
        public int IDMjesta { get; set; }
        [ForeignKey("Karta")]
        public int IdKarte { get; set; }
        public int BrojReda { get; set; }
        public int BrojKolone { get; set; }
    }
}
