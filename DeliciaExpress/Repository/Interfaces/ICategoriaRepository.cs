using DeliciaExpress.Models;

namespace DeliciaExpress.Repository.Interfaces
{
    public interface ICategoriaRepository 
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
