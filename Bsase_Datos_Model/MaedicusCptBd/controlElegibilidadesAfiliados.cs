namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class controlElegibilidadesAfiliados
    {
        [StringLength(50)]
        public string cve_empresa { get; set; }

        [StringLength(100)]
        public string nomina { get; set; }

        public int? numbenef { get; set; }

        [Key]
        [StringLength(50)]
        public string elegibilidad { get; set; }

        public DateTime? fechaCaptura { get; set; }

        [StringLength(50)]
        public string xusrCapturo { get; set; }

        [StringLength(50)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        public int? SecuenciaMAC { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
