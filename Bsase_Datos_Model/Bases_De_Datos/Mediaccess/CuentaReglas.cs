namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CuentaReglas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodRegla { get; set; }

        [StringLength(500)]
        public string Valor { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual Regla Regla { get; set; }
    }
}
