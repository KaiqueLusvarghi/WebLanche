﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLanches.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
    [Required(ErrorMessage = " Informe o nome da categoria")]
    [Display(Name = "Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres")]
    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [Display (Name = "Descrição")]
    public string Descricao { get; set; }

    //Relacionamento de 1 para muitos (1 -> N)
    public List<Lanche> Lanches { get; set; }   
}
