using DeliciaExpress.Context;
using DeliciaExpress.Models;
using DeliciaExpress.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeliciaExpress.Repository
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;
        public LanchesRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(l => l.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
