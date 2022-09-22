using PA2_2022_2C_WebAppMVC.Models;

namespace PA2_2022_2C_WebAppMVC.Data
{
    public interface IProvinciasRepository
    {
        Task<List<Provincias>> ToListAsync();
    }
}
