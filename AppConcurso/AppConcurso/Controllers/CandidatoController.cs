using AppConcurso.Context;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ContextBD _context;
        public CandidatoController(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Models.Candidato>> ListaDeCandidatos()
        {
            var candidatos = await _context.Candidatos.ToListAsync();
            return candidatos;
        }

        public async Task<Candidato> CandidatoPorCpf(string cpf)
        {
            var candidato = await _context.Candidatos.FirstOrDefaultAsync(c => c.cpf_can == cpf);
            return candidato;
        }
        public async Task<Candidato> CandidatoPorNome(string nome)
        {
            var candidato = await _context.Candidatos.FirstOrDefaultAsync(c => c.nome_can == nome);
            return candidato;
        }

        public async Task Add(Candidato candidato)
        {
          
                await _context.Candidatos.AddAsync(candidato);
                await _context.SaveChangesAsync();
            
        }
    }
}
