using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Components.Models;

public class Produto
{
    
    [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
    public string Nome { get; set; } = "";
    
    [Range(0.01, 100000, ErrorMessage = "O preço deve ser maior que R$ 0,00") ]
    public decimal Preco { get; set; }
 
    [Range(1, 100000, ErrorMessage = "A quantidade deve ser maior que 0") ]
    public int Quantidade { get; set; }
    
}