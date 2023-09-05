namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FolioXIdGastosCoberturaDetalle")]
    public partial class FolioXIdGastosCoberturaDetalle
    {
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        public int? idGCD { get; set; }

        [Key]
        [StringLength(50)]
        public string Folio { get; set; }

        [StringLength(50)]
        public string CodProcedimiento { get; set; }
    }
}
