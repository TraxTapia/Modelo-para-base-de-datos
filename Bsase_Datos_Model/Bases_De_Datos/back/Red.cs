namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Red")]
    public partial class Red
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Red()
        {
            SYS_Mediaccess_RED_Cuenta = new HashSet<SYS_Mediaccess_RED_Cuenta>();
            SYS_Mediaccess_RED_Cuenta_Log = new HashSet<SYS_Mediaccess_RED_Cuenta_Log>();
            SYS_Mediaccess_RED_Cuenta1 = new HashSet<SYS_Mediaccess_RED_Cuenta>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Column("Red")]
        [StringLength(50)]
        public string Red1 { get; set; }

        [StringLength(100)]
        public string NombreLargo { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codEstatusRed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Mediaccess_RED_Cuenta> SYS_Mediaccess_RED_Cuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Mediaccess_RED_Cuenta_Log> SYS_Mediaccess_RED_Cuenta_Log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Mediaccess_RED_Cuenta> SYS_Mediaccess_RED_Cuenta1 { get; set; }
    }
}
