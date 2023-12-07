using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabella.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("ProcedimentoId")]
        [Display(Name = "Código Procedimento")]
        public int ProcedimentoId { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

       [ForeignKey("TipoProcedimentoId")]
        public int TipoProcedimentoId { get; set; }

        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
