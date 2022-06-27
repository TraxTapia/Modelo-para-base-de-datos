namespace Bsase_Datos_Model.MaedicusCpt.ECEREMESAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NumeroRemesa")]
    public partial class NumeroRemesa
    {
        [Key]
        [StringLength(50)]
        public string FolioRemesa { get; set; }

        public int? Consecutivo { get; set; }

        public int? Anio { get; set; }

        public int? ClaveProveedor { get; set; }

        [StringLength(5)]
        public string CveEmpresaGrupo { get; set; }

        [StringLength(5)]
        public string ClaveSistema { get; set; }
    }
}
