using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DSTeachers.Models;

[Table("genero")]
public class Genero
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    [StringLength(30)]
    public string Cor { get; set; }
}
