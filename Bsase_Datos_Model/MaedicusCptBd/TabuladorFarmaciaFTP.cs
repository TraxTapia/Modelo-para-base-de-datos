namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmaciaFTP")]
    public partial class TabuladorFarmaciaFTP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string mes { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string dia { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Archivo { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Finsert { get; set; }
    }
}
