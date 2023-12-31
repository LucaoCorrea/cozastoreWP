using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Tamanho")]
public class Tamanho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    
    [Required(ErrorMessage = "Informe o Sigla")]
    [StringLength(5, ErrorMessage = "A Sigla deve possuir no máximo 5 caracteres")]
    public string Sigla { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }

    public ICollection<ProdutoEstoque> Estoques { get; set; }

}
