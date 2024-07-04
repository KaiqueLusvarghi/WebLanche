using Microsoft.EntityFrameworkCore;
using WebLanches.Context;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;

    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }
    //Obetendo todos os lanches e suas categorias
    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=>c.Categoria);

    //Filtrando todos os lanches preferidos e suas categorias 
    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p=> p.IslanchePreferido).Include(c=> c.Categoria);

    //busanco um lanche especifico pelo Id
    public Lanche GetLancheById(int lancheId)
    {
       return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
    }
    
}
