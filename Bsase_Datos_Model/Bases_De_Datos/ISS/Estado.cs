namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estado()
        {
            Poblacion = new HashSet<Poblacion>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string CodEstado { get; set; }

        [Column("Estado")]
        [Required]
        [StringLength(100)]
        public string Estado1 { get; set; }

        public int CodHSBC { get; set; }

        public virtual Pais Pais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poblacion> Poblacion { get; set; }
    }
}
