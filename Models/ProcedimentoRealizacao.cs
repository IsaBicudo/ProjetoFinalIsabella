﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabella.Models
{
    [Table("ProcedimentoRealizacao")]
    public class ProcedimentoRealizacao
    {
        [Column("ProcedimentoRealizacaoId")]
        [Display(Name = "Código Procedimento Realização")]
        public int ProcedimentoRealizacaoId { get; set; }

        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        public int? LocalRealizacaoId { get; set; }

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
