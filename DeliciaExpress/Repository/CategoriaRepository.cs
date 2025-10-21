using DeliciaExpress.Repository.Interfaces;

namespace DeliciaExpress.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Models.AppDbContext _context;
        public CategoriaRepository(Models.AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Models.Categoria> Categorias => _context.Categorias;
    }
}
