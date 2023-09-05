namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Red_Cuenta
    {
        public int? CodRed { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        public DateTime? FechaAsignacion { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? Tabulado { get; set; }

        [StringLength(1)]
        public string Prioridad { get; set; }

        public int? codEstatusRedCuenta { get; set; }
    }
}
