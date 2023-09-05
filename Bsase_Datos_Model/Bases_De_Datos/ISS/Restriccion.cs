namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restriccion")]
    public partial class Restriccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restriccion()
        {
            EmpresaRestriccion = new HashSet<EmpresaRestriccion>();
        }

        [Key]
        [StringLength(20)]
        public string CodRestriccion { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(6)]
        public string Cveg_Tipo_Entidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaRestriccion> EmpresaRestriccion { get; set; }
    }
}
