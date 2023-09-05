namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValidatedFilesMovimientosLog")]
    public partial class ValidatedFilesMovimientosLog
    {
        public int? Id { get; set; }

        [StringLength(200)]
        public string FolioVal { get; set; }

        [StringLength(250)]
        public string Archivo { get; set; }

        public int? Filas_Total { get; set; }

        public int? Filas_OK { get; set; }

        public int? Filas_Error { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Usuario_Carga { get; set; }

        public bool? Estatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [StringLength(10)]
        public string CodeProvider { get; set; }

        public int? RemittanceStatus_Id { get; set; }

        [StringLength(200)]
        public string LeftOvers { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(10)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(4)]
        public string cve_espec { get; set; }

        [StringLength(100)]
        public string Usuario { get; set; }

        public DateTime? Fecha_Cambio { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        [Key]
        [StringLength(10)]
        public string Movimiento { get; set; }
    }
}
