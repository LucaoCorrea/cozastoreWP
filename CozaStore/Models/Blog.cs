using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CozaStore.Models;

[Table("Blog")]
public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Informe o texto")]
    [StringLength(600, ErrorMessage = "O Texto deve possuir no máximo 600 caracteres")]
    public string Text { get; set; }


    [StringLength(300)]
    public string Photo { get; set; }
    
    [Display ]
    [Required(ErrorMessage = "Informe o Autor")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]

    public Usuario Usuario { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}


