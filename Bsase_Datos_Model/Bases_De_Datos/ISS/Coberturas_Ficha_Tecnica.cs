namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Coberturas_Ficha_Tecnica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coberturas_Ficha_Tecnica()
        {
            CoverageFilter = new HashSet<CoverageFilter>();
            Ficha_Tecnica = new HashSet<Ficha_Tecnica>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(800)]
        public string Cobertura { get; set; }

        public DateTime Fecha_Alta { get; set; }

        public DateTime? Fecha_Baja { get; set; }

        public bool Activo { get; set; }

        [StringLength(10)]
        public string CodAgrupador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoverageFilter> CoverageFilter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ficha_Tecnica> Ficha_Tecnica { get; set; }
    }
}
