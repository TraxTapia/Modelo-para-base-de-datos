namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CPT4
    {
        [Required]
        [StringLength(50)]
        public string CodProcedimiento { get; set; }

        [StringLength(255)]
        public string Procedimiento { get; set; }

        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [StringLength(50)]
        public string Especialidad { get; set; }

        public int Id { get; set; }
    }
}
