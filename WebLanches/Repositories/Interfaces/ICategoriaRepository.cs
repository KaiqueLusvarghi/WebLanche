using WebLanches.Models;

namespace WebLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository 
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
