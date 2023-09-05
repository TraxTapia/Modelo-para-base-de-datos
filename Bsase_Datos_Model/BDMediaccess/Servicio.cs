namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servicio")]
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            ausentismo = new HashSet<ausentismo>();
        }

        [Key]
        [StringLength(10)]
        public string CodServicio { get; set; }

        [Column("Servicio")]
        [StringLength(50)]
        public string Servicio1 { get; set; }

        [StringLength(100)]
        public string Codigo_Capacidad { get; set; }

        public bool Incapacidad { get; set; }

        public bool Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ausentismo> ausentismo { get; set; }
    }
}
