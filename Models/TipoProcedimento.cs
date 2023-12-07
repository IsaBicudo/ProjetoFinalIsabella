using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabella.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("TipoProcedimentoId")]
        [Display(Name = "Código TipoProcedimento")]
        public int TipoProcedimentoId { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Tipo do Procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
