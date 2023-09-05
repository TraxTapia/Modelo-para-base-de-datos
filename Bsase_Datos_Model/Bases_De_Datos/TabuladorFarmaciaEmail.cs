namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmaciaEmail")]
    public partial class TabuladorFarmaciaEmail
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Atencion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string correo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string correoc { get; set; }

        [StringLength(3)]
        public string tipo { get; set; }

        public bool? estatus { get; set; }

        public int? estatusCarga { get; set; }
    }
}
