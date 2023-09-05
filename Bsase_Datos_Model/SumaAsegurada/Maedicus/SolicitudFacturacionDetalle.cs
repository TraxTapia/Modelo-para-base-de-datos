namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudFacturacionDetalle")]
    public partial class SolicitudFacturacionDetalle
    {
        public int Id { get; set; }

        public int IdSolicitudFacturacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Remesa { get; set; }

        [Required]
        [StringLength(50)]
        public string RemesaSeguro { get; set; }

        public double Monto { get; set; }

        public double IVA { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(10)]
        public string CveEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        public DateTime fecha_cambio { get; set; }

        public virtual SolicitudFacturacion SolicitudFacturacion { get; set; }
    }
}
