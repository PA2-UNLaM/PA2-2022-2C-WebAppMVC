using System.ComponentModel.DataAnnotations;

namespace PA2_2022_2C_WebAppMVC.Models
{
    public class Provincias
    {
        [Key]
        public int Provincia { get; set; }
        public string? NomProvincia { get; set; }
    }
}
