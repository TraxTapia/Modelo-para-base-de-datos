namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturasEmail")]
    public partial class FacturasEmail
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Atencion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string correo { get; set; }

        [StringLength(150)]
        public string correo1 { get; set; }

        [StringLength(150)]
        public string correo2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(150)]
        public string correoc { get; set; }
    }
}
