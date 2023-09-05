namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorProveedor")]
    public partial class TabuladorProveedor
    {
        public int codTipoGasto { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
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

        public int codTabulador { get; set; }

        [StringLength(10)]
        public string codDescripcion { get; set; }

        public DateTime? fechaCarga { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string xusrInsert { get; set; }

        [Required]
        [StringLength(10)]
        public string anioAplicacion { get; set; }

        public int Id { get; set; }
    }
}
