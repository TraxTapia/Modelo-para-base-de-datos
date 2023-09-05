namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_TB_FacturasLayout
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string remesa { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string secuenciaMac { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime f_envio_pago { get; set; }

        public bool? estatus { get; set; }

        public string mensaje { get; set; }

        [StringLength(50)]
        public string NoLote { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime Fecinsert { get; set; }
    }
}
