namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorProveedorPruebaAlta")]
    public partial class TabuladorProveedorPruebaAlta
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

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Estudio { get; set; }

        public double PrecioPublico { get; set; }

        public double Descuento { get; set; }

        public double PrecioMAC { get; set; }

        [StringLength(1)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        [StringLength(10)]
        public string codDescripcion { get; set; }

        public DateTime? fechaCarga { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string xusrInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string anioAplicacion { get; set; }
    }
}
