using System.ComponentModel.DataAnnotations;

namespace OnlineProdajaKarata.Models
{
    public class User
    {
        [Key]
        public int IDUser { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String Username { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public int BrojKupljenihKarata { get; set; }
    }
}
