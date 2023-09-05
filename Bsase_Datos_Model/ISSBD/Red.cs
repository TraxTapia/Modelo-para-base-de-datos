namespace Bsase_Datos_Model.ISSBD
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
            Empresa = new HashSet<Empresa>();
            RedProveedor = new HashSet<RedProveedor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Column("Red")]
        [Required]
        [StringLength(50)]
        public string Red1 { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreLargo { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codEstatusRed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RedProveedor> RedProveedor { get; set; }
    }
}
