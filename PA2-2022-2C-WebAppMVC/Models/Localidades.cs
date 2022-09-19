using System.ComponentModel.DataAnnotations;

namespace PA2_2022_2C_WebAppMVC.Models
{
    public class Localidades
    {
        public int Provincia { get; set; }
        [Key]
        public int Localidad { get; set; }
        public String? NomLoc { get; set; }
        public int Ciudad { get; set; }
        public String? NomCiudad { get; set; }
    }
}
