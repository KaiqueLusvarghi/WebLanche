using WebLanches.Models;

namespace WebLanches.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Lanche> LanchesPreferidos { get; set; }
}
