namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorProveedor_Log
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

        [StringLength(10)]
        public string codDescripcion { get; set; }

        public DateTime? fechaCarga { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string xusrInsert { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string anioAplicacion { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string xUsrInsertEvento { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime xDateInsertEvento { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codevento { get; set; }

        public virtual sys_mediaccess_EventosRegistrosTablas sys_mediaccess_EventosRegistrosTablas { get; set; }
    }
}
