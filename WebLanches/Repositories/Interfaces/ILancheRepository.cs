using WebLanches.Models;

namespace WebLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        //retorna uma lista de objetos Lanche
        IEnumerable<Lanche> Lanches { get; }
        //retorna uma lista de objetos Lanche onde iremos filtrar os lanches preferidos
        IEnumerable<Lanche> LanchesPreferidos { get; }
        //retorna um objeto pelo seu identificador LancheId
        Lanche GetLancheById(int lancheId);
    }
}
