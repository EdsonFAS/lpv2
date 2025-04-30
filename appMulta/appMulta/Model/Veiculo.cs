using System.ComponentModel.DataAnnotations.Schema;

namespace appMulta.Model
{
    [Table("veiculo")]
    public class Veiculo
    {
        [Column("id_veiculo")]
        public int Id { get; set; }

        [Column("modelo")]
        public string? modelo {  get; set; }

        [Column("marca")]
        public string? marca { get; set; }

        [Column("placa")]
        public string? placa { get; set; }

        public List<Multa>? Multas { get; set; }
    }
}
