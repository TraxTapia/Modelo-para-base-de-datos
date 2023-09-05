namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_RED_Cuenta
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? Prioridad { get; set; }

        public bool Estatus { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual Cuenta Cuenta1 { get; set; }

        public virtual Red Red { get; set; }

        public virtual Red Red1 { get; set; }
    }
}
