namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CPT_CVEPROV_TIPOGASTO4
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime? FechaCarga { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 4)]
        public double Importe { get; set; }
    }
}
