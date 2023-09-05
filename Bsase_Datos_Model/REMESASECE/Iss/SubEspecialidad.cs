namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubEspecialidad")]
    public partial class SubEspecialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubEspecialidad()
        {
            Proveedor = new HashSet<Proveedor>();
            StaffMedico = new HashSet<StaffMedico>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodSubEspecialidad { get; set; }

        [Column("SubEspecialidad")]
        [Required]
        [StringLength(50)]
        public string SubEspecialidad1 { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor> Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffMedico> StaffMedico { get; set; }
    }
}
