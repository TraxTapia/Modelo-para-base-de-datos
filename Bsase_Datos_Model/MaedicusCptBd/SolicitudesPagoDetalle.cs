namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudesPagoDetalle")]
    public partial class SolicitudesPagoDetalle
    {
        public int Id { get; set; }

        public int IdSolicitudesPago { get; set; }

        [Required]
        [StringLength(50)]
        public string RGA { get; set; }

        [Required]
        [StringLength(50)]
        public string Estatus { get; set; }

        public double Monto { get; set; }

        public double IVA { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_cambio { get; set; }

        public int SolicitudFacturacion_Id { get; set; }

        public virtual SolicitudesPago SolicitudesPago { get; set; }

        public virtual SolicitudFacturacion SolicitudFacturacion { get; set; }
    }
}
