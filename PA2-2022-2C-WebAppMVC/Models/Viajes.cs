using System.ComponentModel.DataAnnotations;

namespace PA2_2022_2C_WebAppMVC.Models
{
    public class Viajes
    {
        public const string SessionProvinciaOrigen = "_ProvinciaOrigen";
        public const string SessionNomProvinciaOrigen = "_NomProvinciaOrigen";
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Cliente is required.")]

        public int Cliente { get; set; }
        [Key]
        public int IdServicio { get; set; }
        public int Vehiculo { get; set; }
        [Required(ErrorMessage = "Origen is required.")]
        public int Origen { get; set; }
        public int ProvinciaOrigen { get; set; }
        public int Destino { get; set; }
        public int ProvinciaDestino { get; set; }
        public int Km { get; set; }
        public int CantViajes { get; set; } = 1;

    }
}
