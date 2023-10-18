using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Cor")]
public class Cor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Informe o Hexadecimal da Cor")]
    [StringLength(7, ErrorMessage = "O Hexa deve possuir no máximo 7 caracteres")]
    public string CodigoHexa { get; set; }

public ICollection<ProdutoEstoque> Estoques { get; set; }
}
