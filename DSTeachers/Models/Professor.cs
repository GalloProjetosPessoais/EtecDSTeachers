using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DSTeachers.Models;

[Table("professor")]
public class Professor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [StringLength(20)]
    public string Apelido { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }

    [StringLength(200)]
    public string Audio { get; set; }

    [Required]
    public int AudioGeneroId { get; set; }
    [ForeignKey("AudioGeneroId")]
    public Genero AudioGenero { get; set; }
}
