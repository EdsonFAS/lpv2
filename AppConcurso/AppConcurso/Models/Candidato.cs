using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("candidato")]
    public class Candidato
    {
        [Key]
        [Column("id_can")]
        public int id_can { get; set; }

        [Column("nome_can")]
        public string? nome_can { get; set; }

        [Column("cpf_can")]
        public string? cpf_can { get; set; }

        [Column("data_nasc_can")]
        public DateTime? data_nasc_can { get; set; }

        public List<Inscricao> ? Inscricoes { get; set; }
    }
}
