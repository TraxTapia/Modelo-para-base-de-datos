namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pasoTabuladorProveedor")]
    public partial class pasoTabuladorProveedor
    {
        [StringLength(100)]
        public string codTipoGasto { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodigoProveedor { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [StringLength(200)]
        public string procedimiento { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Estudio { get; set; }

        [Key]
        [Column(Order = 4)]
        public double PrecioPublico { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Descuento { get; set; }

        [Key]
        [Column(Order = 6)]
        public double PrecioMAC { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Autorizacion { get; set; }
    }
}
