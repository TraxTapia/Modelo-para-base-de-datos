namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Medicamentos__reversar
    {
        [Key]
        public int IdMedicamento { get; set; }

        public int? IdCuadro { get; set; }

        public int? IdLaboratorio { get; set; }

        public int? IdSal { get; set; }

        public int? IdGrupo { get; set; }

        [StringLength(10)]
        public string codEspecialidad { get; set; }
    }
}
