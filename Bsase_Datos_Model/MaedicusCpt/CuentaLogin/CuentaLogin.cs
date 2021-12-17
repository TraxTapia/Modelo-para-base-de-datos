namespace Bsase_Datos_Model.MaedicusCpt.CuentaLogin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuentaLogin")]
    public partial class CuentaLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public bool BCambiarClaveAcceso { get; set; }

        [StringLength(255)]
        public string ClaveAcceso { get; set; }

        public DateTime? FhClaveAcceso { get; set; }

        public bool BPrimeraVez { get; set; }

        public bool BEnLinea { get; set; }

        public DateTime? FhUltAutentValid { get; set; }

        public int? NumFallaAutent { get; set; }

        public DateTime? FIniFallaAutent { get; set; }

        [Required]
        [StringLength(1)]
        public string SitUsuario { get; set; }

        public DateTime? FhUltActividad { get; set; }

        [Required]
        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
