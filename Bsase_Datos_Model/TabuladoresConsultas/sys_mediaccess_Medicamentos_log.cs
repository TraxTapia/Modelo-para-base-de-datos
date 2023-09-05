namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Medicamentos_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMedicamento { get; set; }

        public int? IdCuadro { get; set; }

        public int? IdLaboratorio { get; set; }

        public int? IdSal { get; set; }

        public int? IdGrupo { get; set; }

        [StringLength(10)]
        public string codEspecialidad { get; set; }

        [StringLength(1)]
        public string TipoCambio { get; set; }

        [StringLength(50)]
        public string UserInsert { get; set; }

        public DateTime? FechProceso { get; set; }

        [StringLength(700)]
        public string Observaciones { get; set; }
    }
}
