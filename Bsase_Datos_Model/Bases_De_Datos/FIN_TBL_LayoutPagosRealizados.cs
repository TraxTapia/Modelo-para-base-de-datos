namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_TBL_LayoutPagosRealizados
    {
        [Key]
        public int idLote { get; set; }

        [StringLength(40)]
        public string NombreArchivo { get; set; }

        [StringLength(30)]
        public string ClaveArchivo { get; set; }

        public DateTime fechaEnvio { get; set; }
    }
}
