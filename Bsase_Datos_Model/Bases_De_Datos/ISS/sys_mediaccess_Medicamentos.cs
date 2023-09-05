namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Medicamentos
    {
        [Key]
        public int IdMedicamento { get; set; }

        public int? IdCuadro { get; set; }

        public int? IdLaboratorio { get; set; }

        public int? IdSal { get; set; }

        public int? IdGrupo { get; set; }

        public int? IdEspecialidad { get; set; }

        public virtual sys_mediaccess_Cat_Especialidades sys_mediaccess_Cat_Especialidades { get; set; }

        public virtual sys_mediaccess_Cat_Grupos sys_mediaccess_Cat_Grupos { get; set; }

        public virtual sys_mediaccess_Cat_Laboratorios sys_mediaccess_Cat_Laboratorios { get; set; }

        public virtual sys_mediaccess_Cat_Sal sys_mediaccess_Cat_Sal { get; set; }
    }
}
