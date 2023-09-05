namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BandejaEntradaEM")]
    public partial class BandejaEntradaEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cve { get; set; }

        public DateTime? FechaInicioProc { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Edad { get; set; }

        public int? CveTipExa { get; set; }

        [StringLength(50)]
        public string CodEstado { get; set; }

        [StringLength(50)]
        public string CodPoblacion { get; set; }

        [StringLength(50)]
        public string Lada { get; set; }

        [StringLength(50)]
        public string Telefono1 { get; set; }

        [StringLength(50)]
        public string Telefono2 { get; set; }

        [StringLength(50)]
        public string Telefono3 { get; set; }

        public DateTime? FechaExamenMedico { get; set; }

        [StringLength(50)]
        public string CveProveedor { get; set; }

        public int? CodUbicacionProv { get; set; }

        [StringLength(50)]
        public string ObservacionCita { get; set; }

        public int? DiasProceso { get; set; }

        [StringLength(50)]
        public string UsrTermino { get; set; }

        public DateTime? FechaTermino { get; set; }

        [StringLength(50)]
        public string ObservacionTermino { get; set; }

        public int? SeRealizo { get; set; }

        public int? Estatus { get; set; }

        public int? CveRespCoor { get; set; }

        public DateTime? FechaCargaMediaccess { get; set; }

        public DateTime? FechaEnvioFax { get; set; }

        public DateTime? FechaSuscripcion { get; set; }

        [StringLength(50)]
        public string GuiaEnvio { get; set; }
    }
}
