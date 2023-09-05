namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario_Asig_Sistema
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuariosistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAplicacion { get; set; }

        public DateTime? FechaAltaAsignacion { get; set; }

        [StringLength(100)]
        public string UsrAltaAsignacion { get; set; }

        public DateTime? FechaBajaAsignacion { get; set; }

        [StringLength(100)]
        public string UsrBajaAsignacion { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }
    }
}
