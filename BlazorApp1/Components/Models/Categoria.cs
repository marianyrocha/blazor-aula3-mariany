using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Components.Models;
    
public class Categoria
{
    [MinLength(3, ErrorMessage = "O nome da categoria deve conter no mínimo 3 caracteres")]
    [MaxLength(50, ErrorMessage = "O nome da categoria deve conter no máximo 50 caracteres")]
    public string Nome { get; set; } = "";
    
    [Range(0, 100000, ErrorMessage = "Informe uma quantidade válida, a quantidade deve estar entre 0 e 100000")]
    public int Quantidade { get; set; }
}