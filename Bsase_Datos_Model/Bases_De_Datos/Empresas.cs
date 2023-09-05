namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresas()
        {
            Facturas = new HashSet<Facturas>();
        }

        [Key]
        [StringLength(50)]
        public string cve_empresa { get; set; }

        [Required]
        [StringLength(100)]
        public string empresa { get; set; }

        public int? codPlan { get; set; }

        public int codEmpresa { get; set; }

        public int? codTabulador { get; set; }

        public int? requisitosReembolsos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
