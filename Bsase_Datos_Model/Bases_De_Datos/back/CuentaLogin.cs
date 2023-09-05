namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuentaLogin")]
    public partial class CuentaLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaLogin()
        {
            CuentaLoginVersion = new HashSet<CuentaLoginVersion>();
            CuentaSession = new HashSet<CuentaSession>();
        }

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

        public int IdEstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaLoginVersion> CuentaLoginVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaSession> CuentaSession { get; set; }

        public virtual EstatusCuentaProveedor EstatusCuentaProveedor { get; set; }
    }
}
