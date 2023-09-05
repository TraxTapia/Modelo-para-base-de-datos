namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class controlFoliosCapturados
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCopiaFormato { get; set; }

        public DateTime? fechaCaptura { get; set; }

        [StringLength(50)]
        public string usrCapturo { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(10)]
        public string codTabulador { get; set; }

        [StringLength(18)]
        public string consecutivo { get; set; }

        public int? SecuenciaMac { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
