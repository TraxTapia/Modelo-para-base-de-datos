namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CPT4
    {
        [Key]
        [StringLength(50)]
        public string CodProcedimiento { get; set; }

        [StringLength(255)]
        public string Procedimiento { get; set; }

        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [StringLength(50)]
        public string Especialidad { get; set; }
    }
}
