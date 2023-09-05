namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuentaSession")]
    public partial class CuentaSession
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdSession { get; set; }

        public int CodCuenta { get; set; }

        public DateTime InicioSession { get; set; }

        [Required]
        [StringLength(15)]
        public string IPSession { get; set; }

        public virtual CuentaLogin CuentaLogin { get; set; }
    }
}
