namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.RedCuenta18082006")]
    public partial class RedCuenta18082006
    {
        public int? CodRed { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        public DateTime? FechaAsignacion { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? Tabulado { get; set; }
    }
}
