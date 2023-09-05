namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuentaLoginVersion")]
    public partial class CuentaLoginVersion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdVersion { get; set; }

        public DateTime FIniVersion { get; set; }

        public DateTime FFinVersion { get; set; }

        public bool BUltVerDia { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string ClaveAcceso { get; set; }

        [Required]
        [StringLength(1)]
        public string SitUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        public virtual CuentaLogin CuentaLogin { get; set; }
    }
}
