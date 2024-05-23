using System.ComponentModel.DataAnnotations;

namespace OnlineProdajaKarata.Models
{
    public class Manifestacija
    {
        [Key]
        public int IDManifestacije { get; set; }
        public String NazivManifestacije { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public KategorijaManifestacije Kategorija { get; set; }
        public String MjestoOdrzavanja { get; set; }
        public int TrajanjeManifestacije { get; set; }
        public String OpisManifestacije { get; set; }
        public double CijenaKarte { get; set; }
        public String Slika { get; set; }
    }
}
