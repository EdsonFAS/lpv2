using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("inscricao")]
    public class Inscricao
    {
        [Key]
        [Column("id_insc")]
        public int id_insc { get; set; }
        
        [Column("numero_insc")]
        public int? numero_insc { get; set; }
        
        [Column("data_insc")]
        public DateTime? data_insc { get; set; }
        
        [Column("nota_conh_gerais_insc")]
        public double? nota_conh_gerais_insc { get; set; }
        
        [Column("nota_conh_espec_insc")]
        public double? nota_conh_espec_insc { get; set; }

        [Column("id_can_fk")]
        public int id_can_fk { get; set; }
        [ForeignKey("id_can_fk")]
        public Candidato? Candidato { get; set; }

        [Column("id_carg_fk")]
        public int id_carg_fk { get; set; }
        [ForeignKey("id_carg_fk")]
        public Cargo? Cargo { get; set; }
    }
}
