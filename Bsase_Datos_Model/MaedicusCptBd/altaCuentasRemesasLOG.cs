namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("altaCuentasRemesasLOG")]
    public partial class altaCuentasRemesasLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string clav { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string clabe { get; set; }

        [StringLength(40)]
        public string beneficiario { get; set; }

        [StringLength(17)]
        public string cte { get; set; }

        [StringLength(50)]
        public string cuenta { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime fecha { get; set; }

        [StringLength(20)]
        public string remesa { get; set; }

        public DateTime? f_envio_pago { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string codestatusfactura { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciamac { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string no_Fac { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string cve_prov { get; set; }
    }
}
