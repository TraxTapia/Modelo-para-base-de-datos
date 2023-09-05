namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HistoricoContador_Especiales_Bancomext
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CVE_PROV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(50)]
        public string elegibilidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NOMINA { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMBENEF { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime F_OCURRIDO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(18)]
        public string consecutivo { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConsecPase { get; set; }

        public int? SecuenciaMac { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
