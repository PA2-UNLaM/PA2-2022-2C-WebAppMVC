using Microsoft.EntityFrameworkCore;
using PA2_2022_2C_WebAppMVC.Models;

namespace PA2_2022_2C_WebAppMVC.Data
{
    public class EFProvinciasRepository : IProvinciasRepository
    {
        private readonly AppDbContext _context;
        public EFProvinciasRepository(AppDbContext context)
        {
            _context = context;
        }
        Task<List<Provincias>> IProvinciasRepository.ToListAsync()
        {
            return _context.Provincias.ToListAsync();
        }
    }
}
