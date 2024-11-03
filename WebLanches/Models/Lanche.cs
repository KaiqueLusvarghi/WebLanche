using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLanches.Models;
[Table("Lanches")]
public class Lanche
{   
    [Key]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado !")]
    [Display(Name = "Nome do lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
    [Display(Name = "Descrição do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
    [Display(Name = "Descrição detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]
    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o Precço do lanche !")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1,999.99, ErrorMessage = "O Preço deve estar entre 1 e 999,99")]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200,ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemURL { get; set; }


    [Display(Name = "Caminho Imagem Miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemThumbnailURL { get; set;}

    [Display(Name = "Preferido?")]
    public bool IslanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    [Display(Name ="Categorias")]
   //chave estrangeira
    public int CategoriaId { get; set; }

    //Definindo o relacionamento entre lanche e categoria
    public virtual Categoria Categoria { get; set; }    
}