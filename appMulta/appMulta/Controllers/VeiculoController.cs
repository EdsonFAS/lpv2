using appMulta.Context;
using appMulta.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appMulta.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ContextBD _context;
        
        public VeiculoController(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Veiculo>> ListaDeVeiculos()
        {
            var veiculos = await _context.Veiculo.Include(x => x.Multas).ToListAsync();
            return veiculos;
        }

        public async Task<Veiculo> GetVeiculo(string Placa)
        {
            var veiculo= await _context.Veiculo.Include(v => v.placa == Placa).FirstOrDefaultAsync();
            return veiculo;
        }

        public async Task Add(Veiculo veiculo)
        {
            await _context.Veiculo.AddAsync(veiculo);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }

    }
}
