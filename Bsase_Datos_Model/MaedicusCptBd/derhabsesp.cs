namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("derhabsesp")]
    public partial class derhabsesp
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(255)]
        public string no_fac { get; set; }

        public int? secuenciaMac { get; set; }

        [StringLength(100)]
        public string ProvOrigen { get; set; }

        [Required]
        [StringLength(100)]
        public string Nomina { get; set; }

        [Required]
        [StringLength(15)]
        public string Numbenef { get; set; }

        [Required]
        [StringLength(400)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string cve_empresa { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
