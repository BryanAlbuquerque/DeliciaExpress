using DeliciaExpress.Models;

namespace DeliciaExpress.Repository.Interfaces
{
    public interface ILanchesRepository
    {
        IEnumerable<Lanche> lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
