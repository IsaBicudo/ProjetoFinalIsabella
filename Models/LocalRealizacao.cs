using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabella.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("LocalRealizacaoId")]
        [Display(Name = "Código LocalRealização")]
        public int LocalRealizacaoId { get; set; }

        [Column("LocalRealizacaoNome")]
        [Display(Name = "Local da Realização")]
        public string LocalRealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

    }
}
