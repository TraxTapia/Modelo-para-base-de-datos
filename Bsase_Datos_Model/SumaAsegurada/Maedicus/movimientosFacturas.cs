namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movimientosFacturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movimientosFacturas()
        {
            ConceptosMovimiento = new HashSet<ConceptosMovimiento>();
        }

        public DateTime? fechaMovimiento { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        [StringLength(10)]
        public string codestatusfactura { get; set; }

        [StringLength(10)]
        public string codConcepto { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [Column(TypeName = "text")]
        public string observaciones { get; set; }

        public int? SecuenciaMac { get; set; }

        public int Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConceptosMovimiento> ConceptosMovimiento { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
