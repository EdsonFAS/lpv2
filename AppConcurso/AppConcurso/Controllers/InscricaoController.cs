using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly Context.ContextBD _context;
        public InscricaoController(Context.ContextBD context)
        {
            _context = context;
        }
        public async Task<List<Models.Inscricao>> ListaDeInscricoes()
        {
            var inscricoes = await _context.Inscricoes.ToListAsync();
            return inscricoes;
        }
        public async Task<Models.Inscricao> InscricaoPorNumero(int numero)
        {
            var inscricao = await _context.Inscricoes.FirstOrDefaultAsync(i => i.numero_insc == numero);
            return inscricao;
        }

        public async Task<Models.Inscricao> InscricaoPorData(DateTime data)
        {
            var inscricao = await _context.Inscricoes.FirstOrDefaultAsync(i => i.data_insc == data);
            return inscricao;
        }
        public async Task Add(Models.Inscricao inscricao)
        {
            if (inscricao != null)
            {
                await _context.Inscricoes.AddAsync(inscricao);
                await _context.SaveChangesAsync();
            }
        }
    }
}
