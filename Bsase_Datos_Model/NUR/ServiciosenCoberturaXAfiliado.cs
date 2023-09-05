namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiciosenCoberturaXAfiliado")]
    public partial class ServiciosenCoberturaXAfiliado
    {
        public int Id { get; set; }

        public int? idSumaAsegurada { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(10)]
        public string CodEmpresa { get; set; }

        public decimal? Disponible { get; set; }

        public decimal? Gastado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [StringLength(100)]
        public string UsuarioCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(100)]
        public string UsuarioModificacion { get; set; }

        public bool? Excedido { get; set; }

        public decimal? SumaAsegurada { get; set; }
    }
}
