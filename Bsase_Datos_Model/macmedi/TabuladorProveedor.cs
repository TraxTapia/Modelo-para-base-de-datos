namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorProveedor")]
    public partial class TabuladorProveedor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTipoGasto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodigoProveedor { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
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

        [StringLength(1)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }
    }
}
