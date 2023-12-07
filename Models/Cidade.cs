using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabella.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Código Cidade")]
        public int CidadeId { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Cidade")]
        public string CidadeNome { get; set; } = string.Empty;


        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
