namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_Producto_Autorizado
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Cpt { get; set; }

        [Required]
        [StringLength(10)]
        public string CodTabulador { get; set; }

        [Required]
        [StringLength(10)]
        public string CodServicio { get; set; }

        public int Cantidad { get; set; }

        public decimal PU { get; set; }

        public decimal Total { get; set; }

        [Required]
        [StringLength(10)]
        public string CopagoEn { get; set; }

        public int Copago { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime F_Ocurrido { get; set; }

        public bool Surtido { get; set; }

        public int? Codcuenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? F_Surtido { get; set; }
    }
}
