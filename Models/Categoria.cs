using System.ComponentModel.DataAnnotations;

namespace trabalho_dev_web_avancado.Models;

public class Categoria
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome da categoria é obrigatório.")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 80 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [StringLength(200, ErrorMessage = "Descrição deve ter no máximo 200 caracteres.")]
    public string? Descricao { get; set; }
}
