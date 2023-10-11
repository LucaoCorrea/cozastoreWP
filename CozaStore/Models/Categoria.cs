using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

    [Table("Produto")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }

    [StringLength(300)]
    [Display(Name = "Foto de Capa")]
    public string Foto { get; set; }

    
    [Display(Name = "Exibir para Filto?")]
    public bool Filtrar { get; set; } = false;

    
     [Display(Name = "Exibir como Banner?")]
    public bool Banner { get; set; } = false;

    public byte? CategoriaPaiId { get; set; }
    [ForeignKey("CategoriaPaiId")]
    public Categoria CategoriaPai { get; set; }
}
