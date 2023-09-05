namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_RED_Cuenta_Log
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Estatus { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual Red Red { get; set; }
    }
}
