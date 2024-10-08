﻿using WebLanches.Context;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> Categorias => _context.Categorias;
}
