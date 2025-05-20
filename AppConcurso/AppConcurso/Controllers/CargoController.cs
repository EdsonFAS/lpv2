using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class CargoController : Controller
    {
        private readonly Context.ContextBD _context;
        public CargoController(Context.ContextBD context)
        {
            _context = context;
        }
        public async Task<List<Models.Cargo>> ListaDeCargos()
        {
            var cargos = await _context.Cargos.ToListAsync();
            return cargos;
        }
        public async Task<Models.Cargo> CargoPorNome(String nome)
        {
            var cargo = await _context.Cargos.FirstOrDefaultAsync(c => c.nome_carg == nome);
            return cargo;
        }
        public async Task Add(Models.Cargo cargo)
        {
            if (cargo != null)
            {
                await _context.Cargos.AddAsync(cargo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
