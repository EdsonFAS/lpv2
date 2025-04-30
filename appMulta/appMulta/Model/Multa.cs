using System.ComponentModel.DataAnnotations.Schema;

namespace appMulta.Model
{
    [Table("multa")]
    public class Multa
    {
        [Column("id_multa")]
        public int Id { get; set; }

        [Column("descricao")]
        public string? descricao { get; set; }

        [Column("valor")]
        public double? valor {  get; set; }

        [Column("id_veiculo")]
        public int? Idveiculo { get; set; }

        [ForeignKey("Idveiculo")]
        public Veiculo? Veiculo { get; set; }
    }
}
