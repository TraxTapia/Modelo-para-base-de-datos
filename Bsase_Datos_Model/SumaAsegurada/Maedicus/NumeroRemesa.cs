namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
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

        public virtual EmpresaGrupo EmpresaGrupo { get; set; }

        public virtual Sistema Sistema { get; set; }
    }
}
