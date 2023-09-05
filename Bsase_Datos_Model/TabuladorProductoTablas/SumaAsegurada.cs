namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SumaAsegurada")]
    public partial class SumaAsegurada
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }

        [Column("SumaAsegurada")]
        public decimal? SumaAsegurada1 { get; set; }

        [Column("FechaCreacion ")]
        public DateTime? FechaCreacion_ { get; set; }

        [StringLength(100)]
        public string UsuarioCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(100)]
        public string UsuarioModificacion { get; set; }

        [StringLength(70)]
        public string Descripcion { get; set; }
    }
}
