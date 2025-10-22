using DeliciaExpress.Context;
using DeliciaExpress.Repository.Interfaces;

namespace DeliciaExpress.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Models.Categoria> Categorias => _context.Categorias;
    }
}
