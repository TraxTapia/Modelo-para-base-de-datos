namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transferencias_TB_Facturas
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

        public int? secuenciaMac { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime f_envio_pago { get; set; }

        public bool? estatus { get; set; }

        public string mensaje { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
