namespace WebLanches.Models;

public class Lanche
{
    public int LancheId { get; set; }
    public string Nome { get; set; }
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemURL { get; set; }
    public string ImagemThumbnailURL { get; set;}
    public bool IslanchePreferido { get; set; }
    public bool EmEstoque { get; set; }

    //Definindo o relacionamento entre lanche e categoria
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }    
}