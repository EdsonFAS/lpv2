using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("cargo")]
    public class Cargo
    {
        [Key]
        [Column("id_carg")]
        public int id_carg { get; set; }

        [Column("nome_carg")]
        public string? nome_carg { get; set; }

        [Column("salario_base_carg")]
        public double? salario_base_carg { get; set; }

    }
}
