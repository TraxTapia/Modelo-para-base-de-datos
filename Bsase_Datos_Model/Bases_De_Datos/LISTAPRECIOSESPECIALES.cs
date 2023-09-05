namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LISTAPRECIOSESPECIALES
    {
        [StringLength(20)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string tipogasto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tabulador { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string DescripcionCorta { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string DescripcionLarga { get; set; }

        [Key]
        [Column(Order = 7)]
        public double Importe { get; set; }
    }
}
