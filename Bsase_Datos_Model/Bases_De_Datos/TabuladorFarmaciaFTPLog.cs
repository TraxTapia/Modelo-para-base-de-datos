namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmaciaFTPLog")]
    public partial class TabuladorFarmaciaFTPLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string año { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string mes { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string dia { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string Archivo { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Finsert { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool DescargaFTP { get; set; }

        public int? Registros { get; set; }

        public int? Rechazos { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }
    }
}
